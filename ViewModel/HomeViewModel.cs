using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
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

        LobbyViewModel LobbyViewModel = new LobbyViewModel();
        public void GetLobbies()
        {
            ObservableCollection<Lobby> lobbies = LobbyViewModel.LoadLobbies();

            Lobbies = lobbies;
        }
    }
}
