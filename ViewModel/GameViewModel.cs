using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using LoveLetter_GruppeOpgave.Model;

namespace LoveLetter_GruppeOpgave.ViewModel { 
    public class GameViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Player> players;
        private int localPlayerSeat;


        public GameViewModel(ObservableCollection<Player> players, int localPlayerSeat)
        {
            Players = players;
            LocalPlayerSeat = localPlayerSeat;
        }

        public ObservableCollection<Player> Players
        {
            get { return players; }
            set
            {
                if (players == value) return;
                players = value;
                OnPropertyChanged("Players");
            }
        }
        public int LocalPlayerSeat
        {
            get { return localPlayerSeat; }
            set
            {
                if (localPlayerSeat == value) return;
                localPlayerSeat = value;
                OnPropertyChanged("LocalPlayerSeat");
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            var handler = this.PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
