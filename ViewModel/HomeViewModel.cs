using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using LoveLetter_GruppeOpgave.Model;
using LoveLetter_GruppeOpgave.ViewModel;

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
            ObservableCollection<Lobby> lobbies = new ObservableCollection<Lobby>();
            Player player1 = new Player(1, "Hermione Er LÆKKER");
            Player player2 = new Player(2, "Harry Lorter");
            Player player3 = new Player(3, "Voldemort");
            Lobby lobby = new Lobby { Id = 1, LobbyLeader = player1, NumberOfPlayers = 3, Players = { player1, player2, player3 } };
            lobbies.Add(lobby);

            Lobbies = lobbies;
        }

    }
}
