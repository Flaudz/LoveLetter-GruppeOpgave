
using LoveLetter_GruppeOpgave.Model;
using LoveLetter_GruppeOpgave.ViewModel;
using LoveLetter_GruppeOpgave.ViewModel.Commands;
using System;
using System.Collections.ObjectModel;
using Microsoft.VisualBasic;
using System.Windows;
using System.Printing;





namespace LoveLetter_GruppeOpgave.ViewModel
{
    public class HomeViewModel
    {
        Lobby chosenLobby;
        SimpleCommand simpleCommand = new SimpleCommand(mainWindowViewModel);
        private DeckModel deck = new DeckModel();
        public AddToLobbiesCommand AddToLobbiesCommand { get; set; }
        public JoinLobbyCommand JoinLobbyCommand { get; set; }
        // Constructor tror jeg
        public ObservableCollection<Lobby> Lobbies
        {
            get;
            set;
        }
        public static MainWindowViewModel mainWindowViewModel { get; private set; }
        public Lobby ChosenLobby { get => chosenLobby; set => chosenLobby = value; }

        public HomeViewModel()
        {
            AddToLobbiesCommand = new AddToLobbiesCommand(this);
            JoinLobbyCommand = new JoinLobbyCommand(this);

            // Databasen skal have all lobbies inde i sig og så skal alle de lobbies vises på homescreen
            ObservableCollection<Lobby> lobbies = new ObservableCollection<Lobby>();
            Player player1 = new Player(1, "uaehfuogahui");
            Player player2 = new Player(2, "Harry Lorter");
            Player player3 = new Player(3, "Voldemort");
            Lobby lobby = new Lobby(1,player1,4,new ObservableCollection<Player>{ player1, player2 } );
            lobbies.Add(lobby);
            ChosenLobby = lobby;
            Lobbies = lobbies;
            deck.DeckCreator();
            deck.ShuffleDeck();
        }

        public void JoinLobby()
        {
            ChosenLobby.Players[0].Name = "Fisk";
            ChosenLobby.Players.Add(simpleCommand.GameViewModel.LocalPlayer);
        }

        public void MakeNewLobby()
        {
            // Rando934qlmp skal erstattes med det navn som brugeren loggede ind med
            string loggedInName = simpleCommand.GameViewModel.LocalPlayer.Name;

            Player myPlayerObject = new Player(4, loggedInName);
            int indexOfLobby = 55;
            // Her laver vi en ny lobby som også skal ind i databasen
            Lobby newLobby = new Lobby(indexOfLobby, myPlayerObject, 1, new ObservableCollection<Player> { myPlayerObject});
            // Her tjekker vi om den ny lobby allerede findes i Lobbies
            if (!Lobbies.Contains(newLobby))
            {
                Lobbies.Add(newLobby);
            }


            // Her skal vi sætte lobbyen ind i databasen, men da vi ikke har lært om det endnu så har jeg ikke lavet det
        }




    }
}
