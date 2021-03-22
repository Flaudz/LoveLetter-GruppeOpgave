using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{
    public class Lobby
    {
        private int id;
        private Player lobbyLeader;
        private int numberOfPlayers;
        private ObservableCollection<Player> players;


        public int Id { get => id; set => id = value; }
        public Player LobbyLeader { get => lobbyLeader; set => lobbyLeader = value; }
        public int NumberOfPlayers { get => numberOfPlayers; set => numberOfPlayers = value; }
        public ObservableCollection<Player> Players { get => players; set => players = value; }
    }
}
