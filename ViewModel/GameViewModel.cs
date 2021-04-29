using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using LoveLetter_GruppeOpgave.Model;
using LoveLetter_GruppeOpgave.ViewModel.Commands;

namespace LoveLetter_GruppeOpgave.ViewModel { 
    public class GameViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Player> players;
        private Player localPlayer = new Player(1,"");
        private DeckModel deck = new DeckModel();
        private bool localTurn = false;
        private bool targeting = false;
        private string guardPannelState = "Hidden";
        private int playerTurn = 1;
        private CardModel card = new CardModel();
        private Player targetPlayer;
        private ObservableCollection<Player> opponents;
        private int turnCount;


        public CardSelectCommand cardSelectCommand { get; set; }
        public TargetPlayerCommand targetPlayerCommand { get; set; }
        public GuardGuessCommand guardGuessCommand { get; set; }

        public GameViewModel()
        {
            card.Identify(card, 5);
            cardSelectCommand = new CardSelectCommand();
            targetPlayerCommand = new TargetPlayerCommand();
            guardGuessCommand = new GuardGuessCommand();
        }

        public ObservableCollection<Player> Players
        {
            get { return players; }
            set
            {
                if (players == value) return;
                players = value;
                OnPropertyChanged("Players");
            }
        }
        public DeckModel Deck
        {
            get { return deck; }
            set
            {
                if (deck == value) return;
                deck = value;
                OnPropertyChanged("Deck");
            }
        }
        public bool LocalTurn
        {
            get { return localTurn; }
            set
            {
                if (localTurn == value) return;
                localTurn = value;
                OnPropertyChanged("LocalTurn");
            }
        }
        public bool Targeting
        {
            get { return targeting; }
            set
            {
                if (targeting == value) return;
                targeting = value;
                OnPropertyChanged("Targeting");
            }
        }
        public string GuardPannelState
        {
            get { return guardPannelState; }
            set
            {
                if (guardPannelState == value) return;
                guardPannelState = value;
                OnPropertyChanged("GuardPannelState");
            }
        }
        public int PlayerTurn
        {
            get { return playerTurn; }
            set
            {
                if (playerTurn == value) return;
                playerTurn = value;
                OnPropertyChanged("PlayerTurn");
            }
        }
        public Player LocalPlayer
        {
            get { return localPlayer; }
            set
            {
                if (localPlayer == value) return;
                localPlayer = value;
                OnPropertyChanged("LocalPlayer");
            }
        }

        public CardModel Card { get => card; set => card = value; }
        public Player TargetPlayer { get => targetPlayer; set => targetPlayer = value; }
        public ObservableCollection<Player> Opponents { get => opponents; set => opponents = value; }
        public int TurnCount { get => turnCount; set => turnCount = value; }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void GetOpponents()
        {
            Opponents = Players;
            Opponents.Remove(LocalPlayer);
        }

        public void GameStart()
        {
            TurnCount = 0;
            if(localPlayer.Seat == 1)
            {
                //send TurnCount
                Deck.DeckCreator();
                Deck.ShuffleDeck();
                //API send deck
            }
            else
            {
                //Deck.Deck = API get deck
            }
            Deck.HiddenCard = Deck.Deck[0];
            Deck.Deck.RemoveAt(0);
            for (int i = 1; i < 5; i++)
            {
                foreach(Player player in Players)
                {
                    if(player.Seat == i)
                    {
                        player.OnHand.Add(Deck.Deck[0]);
                        Deck.Deck.RemoveAt(0);
                    }
                }
            }
            TurnStart();
        }

        public void TurnStart()
        {
            foreach(Player player in Players)
            {
                if(player.Seat == PlayerTurn)
                {
                    player.DrawCard(Deck.Deck[0]);
                    Deck.Deck.RemoveAt(0);
                }
                if(player == LocalPlayer)
                {
                    LocalTurn = true;
                }
            }
            if (!localTurn)
            {
                int dBPlayerTurn;
                int guardGuess = 0;
                do
                {
                    dBPlayerTurn = 0;
                    //get TurnCount from DB
                    //get guardguess from DB
                    //get card.id from DB
                    //get target.name from DB
                }
                while (dBPlayerTurn == PlayerTurn || dBPlayerTurn == 0);
                if (dBPlayerTurn != PlayerTurn)
                {
                    CardPlay(guardGuess);
                }
            }
        }

        public void TurnEnd()
        {
            TurnCount++;
            //send TurnCount to DB
            int deadPlayerCount = 0;
            foreach (Player player in Players)
            {
                if(player.OnHand.Count == 0)
                {
                    deadPlayerCount++;
                }
            }
            bool gameover = false;
            LocalTurn = false;
            bool playerDead = false;
            do
            {
                PlayerTurn++;
                if (PlayerTurn == 5)
                {
                    PlayerTurn = 1;
                }
                foreach (Player player in Players)
                {
                    if(player.Seat == PlayerTurn && player.OnHand.Count > 0)
                    {
                        playerDead = false;
                        break;
                    }
                    else
                    {
                        playerDead = true;
                    }
                }
            } while (playerDead);
            if(Deck.Deck.Count == 0 || deadPlayerCount == Players.Count-1)
            {
                EndRound();
                foreach(Player player in Players)
                {
                    if (player.Points == 7 - Players.Count)
                    {
                        gameover = true;
                        //EndGame
                    }
                }
                if (!gameover)
                {
                    GameStart();
                }
            }
            else
            {
                TurnStart();
            }
        }

        public void EndRound()
        {
            Player winner = null;
            bool tie = false;
            foreach(Player player in Players)
            {
                if(winner == null && player.OnHand.Count != 0)
                {
                    winner = player;
                }
                else
                {
                    if(player.OnHand.Count != 0)
                    {
                        if(player.OnHand[0].Id >= winner.OnHand[0].Id)
                        {
                            if(player.OnHand[0].Id == winner.OnHand[0].Id)
                            {
                                tie = true;
                            }
                            else
                            {
                                tie = false;
                                winner = player;
                            }
                        }
                    }
                }
            }
            if (!tie)
            {
                winner.Points++;
            }
        }

        public void CardSelect(CardModel card)
        {
            Targeting = true;
            Card = card;
            //send Card to DB
        }

        public void TargetSelect(Player target)
        {
            TargetPlayer = target;
            if(Card.Id == 1)
            {
                GuardPannelState = "Visible";
            }
            else
            {
                CardPlay(0);
            }
            //send Target to DB
        }

        public void CardPlay(int guardGuess)
        {
            //send guardGuess to DB
            foreach (Player player in Players)
            {
                if (player.Seat == PlayerTurn)
                {
                    card.Effect(player, guardGuess, TargetPlayer, Deck.Deck[0]);
                    player.OnPlay(Card);
                    TurnEnd();
                }
            }
        }
    }
}
