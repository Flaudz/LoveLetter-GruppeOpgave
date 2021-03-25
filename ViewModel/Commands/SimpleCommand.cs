using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace LoveLetter_GruppeOpgave.ViewModel.Commands
{
    public class SimpleCommand : ICommand
    {
        public MainWindowViewModel ViewModel { get; set; }
        public SimpleCommand(MainWindowViewModel mainWindowViewModel)
        {
            this.ViewModel = mainWindowViewModel;
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            this.ViewModel.StartGame();
        }
    }
}
