
using LoveLetter_GruppeOpgave.Model;
using LoveLetter_GruppeOpgave.ViewModel;
using LoveLetter_GruppeOpgave.ViewModel.Commands;
using System;
using System.Collections.ObjectModel;

namespace LoveLetter_GruppeOpgave.ViewModel
{
    public class HomeViewModel
    {
        public AddToLobbiesCommand AddToLobbiesCommand { get; set; }
        // Constructor tror jeg
        public ObservableCollection<Lobby> Lobbies
        {
            get;
            set;
        }

        public HomeViewModel()
        {
            AddToLobbiesCommand = new AddToLobbiesCommand(this);

            // Databasen skal have all lobbies inde i sig og så skal alle de lobbies vises på homescreen
            ObservableCollection<Lobby> lobbies = new ObservableCollection<Lobby>();
            Player player1 = new Player(1, "Hermione Er LÆKKER");
            Player player2 = new Player(2, "Harry Lorter");
            Player player3 = new Player(3, "Voldemort");
            Lobby lobby = new Lobby(1,player1,3,new ObservableCollection<Player>{ player1, player2, player3 } );
            lobbies.Add(lobby);

            Lobbies = lobbies;
        }

        public void MakeNewLobby()
        {
            // Rando934qlmp skal erstattes med det navn som brugeren loggede ind med
            string loggedInName = "Rando934qlmp";
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
