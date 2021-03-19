using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using LoveLetter_GruppeOpgave.Model;

namespace LoveLetter_GruppeOpgave.ViewModel
{
    public class LobbyViewModel
    {
        public ObservableCollection<Lobby> Lobbies
        {
            get;
            set;
        }

        public void LoadLobbies()
        {
            ObservableCollection<Lobby> lobbies = new ObservableCollection<Lobby>();

            lobbies.Add(new Lobby { Id = 1, LobbyLeader = new Player(1, "Nicolaj"), Players = new ObservableCollection<Player>{ new Player(1, "Nicolaj"), new Player(2, "Jimmy"), new Player(3, "Christian") }, NumberOfPlayers = 3 });
        }

    }
}
