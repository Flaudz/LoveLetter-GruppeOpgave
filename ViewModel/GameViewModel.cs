using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using LoveLetter_GruppeOpgave.Model;

namespace LoveLetter_GruppeOpgave.ViewModel { 
    public class GameViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Player> players;
        private Player localPlayer = new Player(1,"");
        private int localPlayerSeat;
        private DeckModel deck = new DeckModel();
        private bool localTurn = false;
        private bool targeting = false;
        private string guardPannelState = "Hidden";
        private int playerTurn = 1;

        public GameViewModel()
        {
            
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
        public int LocalPlayerSeat
        {
            get { return localPlayerSeat; }
            set
            {
                if (localPlayerSeat == value) return;
                localPlayerSeat = value;
                OnPropertyChanged("LocalPlayerSeat");
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

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void SetPlayers(ObservableCollection<Player> players)
        {
            Players = players;
            Players.Remove(LocalPlayer);
        }

        public void GameStart()
        {
            if(localPlayerSeat == 1)
            {
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
            }
            if(PlayerTurn == LocalPlayerSeat)
            {
                LocalTurn = true;
            }
        }

        public void TurnEnd()
        {
            bool gameover = false;
            LocalTurn = false;
            PlayerTurn++;
            if(PlayerTurn == 5)
            {
                PlayerTurn = 1;
            }
            if(Deck.Deck.Count == 0)
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
                if(winner != null && player.OnHand.Count != 0)
                {
                    winner = player;
                }
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
            if (!tie)
            {
                winner.Points++;
                if (winner.Points == 7 - Players.Count)
                {
                    //EndGame
                }
            }
        }

        public void CardSelect()
        {
            Targeting = true;

        }
    }
}
