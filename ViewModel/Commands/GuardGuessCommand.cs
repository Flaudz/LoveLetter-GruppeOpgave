using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using LoveLetter_GruppeOpgave.Model;

namespace LoveLetter_GruppeOpgave.ViewModel.Commands
{
    public class GuardGuessCommand : ICommand
    {

        public GuardGuessCommand()
        {
        }


        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            GameViewModel gameViewModel = (GameViewModel)App.Current.Resources["sharedGameViewModel"];
            int guess = (int)parameter;
            gameViewModel.CardPlay(guess);
        }
    }
}
