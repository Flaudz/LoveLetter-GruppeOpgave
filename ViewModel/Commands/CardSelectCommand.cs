using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LoveLetter_GruppeOpgave.ViewModel.Commands
{
    class CardSelectCommand : ICommand
    {

        public GameViewModel GameViewModel { get; set; }
        public CardSelectCommand()
        {
            GameViewModel = (GameViewModel)App.Current.Resources["sharedGameViewModel"];
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            GameViewModel.CardSelect();
        }
    }
}
