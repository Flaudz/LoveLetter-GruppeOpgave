using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using LoveLetter_GruppeOpgave.Model;
using LoveLetter_GruppeOpgave.ViewModel;
using LoveLetter_GruppeOpgave.Views;

namespace LoveLetter_GruppeOpgave.ViewModel
{
    public class HomeViewModel
    {

        public ObservableCollection<Lobby> Lobbies
        {
            get;
            set;
        }

        public HomeViewModel()
        {
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
            string loggedInName = "Rando934qlmp";
            Player myPlayerObject = new Player(4, loggedInName);
            int indexOfLobby = 55;
            // Her laver vi en ny lobby som også skal ind i databasen
            Lobby newLobby = new Lobby(indexOfLobby, myPlayerObject, 1, new ObservableCollection<Player> { myPlayerObject});
            Lobbies.Add(newLobby);

            // Her skal vi sætte lobbyen ind i databasen, men da vi ikke har lært om det endnu så har jeg ikke lavet det
        }

    }
}
