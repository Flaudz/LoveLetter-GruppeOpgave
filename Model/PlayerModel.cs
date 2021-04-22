using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{

    public class Player : INotifyPropertyChanged
    {
        private int id;
        private string name;
        private ObservableCollection<CardModel> onHand;
        private ObservableCollection<CardModel> cardsThrown;
        private bool targeteble;
        private bool hasContessa;
        private int seat;
        private int points;

        public int Id {
            get { return id; }
            set
            {
                if (id == value) return;
                id = value;
                OnPropertyChanged("Id");
            }
        }
        public string Name {
            get { return name; }
            set
            {
                if (name == value) return;
                name = value;
                OnPropertyChanged("Name");
            }
        }
        public ObservableCollection<CardModel> OnHand {
            get { return onHand; }
            set
            {
                if (onHand == value) return;
                onHand = value;
                OnPropertyChanged("OnHand");
            }
        }
        public ObservableCollection<CardModel> CardsThrown {
            get { return cardsThrown; }
            set
            {
                if (cardsThrown == value) return;
                cardsThrown = value;
                OnPropertyChanged("CardsThrown");
            }
        }
        public bool Targeteble {
            get { return targeteble; }
            set
            {
                if (targeteble == value) return;
                targeteble = value;
                OnPropertyChanged("Targeteble");
            }
        }
        public bool HasContessa {
            get { return hasContessa; }
            set
            {
                if (hasContessa == value) return;
                hasContessa = value;
                OnPropertyChanged("HasContessa");
            }
        }
        public int Seat {
            get { return seat; }
            set
            {
                if (seat == value) return;
                seat = value;
                OnPropertyChanged("Seat");
            }
        }
        public int Points {
            get { return points; }
            set
            {
                if (points == value) return;
                points = value;
                OnPropertyChanged("Points");
            }
        }

        public Player(int id, string name)
        {
            Id = id;
            Name = name;
            Targeteble = true;
            HasContessa = false;
        }

        public void DrawCard(CardModel card)
        {
            OnHand.Add(card);
            if (!HasContessa)
            {
                if(card.Id == 7)
                {
                    HasContessa = true;
                }
            }
        }

        public void OnPlay(int cardposition)
        {
            if (HasContessa)
            {
                foreach(CardModel card in OnHand)
                {
                    int i = 2;
                    if(card.Id == 5 || card.Id == 6)
                    {
                        cardposition = i - 1;
                    }
                    i--;
                }
            }
            CardsThrown.Add(OnHand[cardposition]);
            OnHand.RemoveAt(cardposition);
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
