using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using LoveLetter_GruppeOpgave;
using LoveLetter_GruppeOpgave.ViewModel;

namespace LoveLetter_GruppeOpgave.Views
{
    /// <summary>
    /// Interaction logic for HomeScreenViews.xaml
    /// </summary>
    public partial class HomeScreenViews : Window
    {
        public HomeScreenViews()
        {
            InitializeComponent();
            //this.Title = GameViewModel.LocalPlayer.Name;
        }
        //public GameViewModel GameViewModel = (GameViewModel)App.Current.Resources["sharedGameViewModel"];

    }
        
    
}
