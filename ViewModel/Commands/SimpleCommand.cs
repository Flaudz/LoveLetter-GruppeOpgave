using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;


namespace LoveLetter_GruppeOpgave.ViewModel.Commands
{
    public class SimpleCommand : ICommand
    {
        public GameViewModel GameViewModel { get; set; }
        public MainWindowViewModel ViewModel { get; set; } //Property fra MainWindowViewModel
        public SimpleCommand(MainWindowViewModel mainWindowViewModel) //Constructor af classen
        {
            this.ViewModel = mainWindowViewModel;
            GameViewModel = (GameViewModel)App.Current.Resources["sharedGameViewModel"];
        }
        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter) //Executer metoden StartGame fra MainWindowViewModel
        {
            GameViewModel.LocalPlayer.Name = this.ViewModel.GivenName;
            this.ViewModel.StartGame();
        }
    }
}
