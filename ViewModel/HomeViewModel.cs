using System;
using System.Collections.Generic;
using System.Text;
using LoveLetter_GruppeOpgave.ViewModel;

namespace LoveLetter_GruppeOpgave.ViewModel
{
    public class HomeViewModel
    {
        LobbyViewModel LobbyViewModel = new LobbyViewModel();
        private void GetLobbies()
        {
            LobbyViewModel.LoadLobbies();
        }
    }
}
