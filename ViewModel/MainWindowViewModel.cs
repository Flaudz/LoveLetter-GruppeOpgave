using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Input;
using LoveLetter_GruppeOpgave.ViewModel;
using LoveLetter_GruppeOpgave.ViewModel.Commands;
using LoveLetter_GruppeOpgave.Views;

namespace LoveLetter_GruppeOpgave.ViewModel
{
    public class MainWindowViewModel : Window
    {
        public SimpleCommand simpleCommand { get; set; }  //En del af binding til knappen. Fortsætter i SimpleCommand.cs
        public MainWindowViewModel()
        {
            this.simpleCommand = new SimpleCommand(this);

        }
         public void StartGame() //Funktionaliteten af knappen. Den åbner et nyt vindue (HomeScreenViews)
        {
            HomeScreenViews homeScreenViews = new HomeScreenViews();
            homeScreenViews.Show();
            /*MainWindow mainWindow = new MainWindow();
            mainWindow.Close();*/

        }
    }
}
