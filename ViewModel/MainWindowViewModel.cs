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
        private string givenName;
        public SimpleCommand simpleCommand { get; set; }  //En del af binding til knappen. Fortsætter i SimpleCommand.cs
        public string GivenName { get => givenName; set => givenName = value; }

        public MainWindowViewModel()
        {
            this.simpleCommand = new SimpleCommand(this);

        }
         public void StartGame() //Funktionaliteten af knappen. Den åbner et nyt vindue (HomeScreenViews)
        {
            HomeScreenViews homeScreenViews = new HomeScreenViews();
            homeScreenViews.Show();
            

        }
    }
}
