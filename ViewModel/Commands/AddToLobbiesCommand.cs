using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LoveLetter_GruppeOpgave.ViewModel.Commands
{
    public class AddToLobbiesCommand : ICommand
    {

        public HomeViewModel HomeViewModel { get; set; }
        public AddToLobbiesCommand(HomeViewModel homeViewModel)
        {
            HomeViewModel = homeViewModel;
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            HomeViewModel.AddToLobbies();
        }
    }
}
