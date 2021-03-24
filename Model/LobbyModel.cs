using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{
    public class Lobby : INotifyPropertyChanged
    {
        // Fields
        private int id;
        private Player lobbyLeader;
        private int numberOfPlayers;
        private ObservableCollection<Player> players;

        // Constructor
        public Lobby(int id, Player lobbyLeader, int numberOfPlayers, ObservableCollection<Player> players)
        {
            this.id = id;
            this.lobbyLeader = lobbyLeader;
            this.numberOfPlayers = numberOfPlayers;
            this.players = players;
        }

        // I dont Know
        public int Id
        {
            get { return id; }
            set
            {
                if (id == value) return;
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public Player LobbyLeader
        {
            get { return lobbyLeader; }
            set
            {
                if (lobbyLeader == value) return;
                lobbyLeader = value;
                OnPropertyChanged("LobbyLeader");
            }
        }
        public int NumberOfPlayers
        {
            get { return numberOfPlayers; }
            set
            {
                if (numberOfPlayers == value) return;
                numberOfPlayers = value;
                OnPropertyChanged("NumberOfPlayers");
            }
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


        // This is to update the gui when something has changed
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

    }
}
