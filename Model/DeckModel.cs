using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Security.Cryptography;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{
    public class DeckModel : INotifyPropertyChanged
    {
        private ObservableCollection<CardModel> deck;
        private CardModel hiddenCard;

        public ObservableCollection<CardModel> Deck
        {
            get { return deck; }
            set
            {
                if (deck == value) return;
                deck = value;
                OnPropertyChanged("Deck");
            }
        }
        public CardModel HiddenCard
        {
            get { return hiddenCard; }
            set
            {
                if (hiddenCard == value) return;
                hiddenCard = value;
                OnPropertyChanged("HiddenCard");
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

        public DeckModel()
        {
        }

        //jeg er ikke sikker på om dette virker, siden at det er lidt svært at teste.

        public void DeckCreator()
        {
            Deck = new ObservableCollection<CardModel>();

            for (int i = 1; i < 17; i++)
            {
                CardModel card = new CardModel();
                switch (i)
                {
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                        card.Identify(card, 1);
                        break;
                    case 6:
                    case 7:
                        card.Identify(card, 2);
                        break;
                    case 8:
                    case 9:
                        card.Identify(card, 3);
                        break;
                    case 10:
                    case 11:
                        card.Identify(card, 4);
                        break;
                    case 12:
                    case 13:
                        card.Identify(card, 5);
                        break;
                    case 14:
                        card.Identify(card, 6);
                        break;
                    case 15:
                        card.Identify(card, 7);
                        break;
                    case 16:
                        card.Identify(card, 8);
                        break;
                    default:
                        continue;
                }
                Deck.Add(card);
            }
        }

        public void ShuffleDeck()
        {
            RNGCryptoServiceProvider Random = new RNGCryptoServiceProvider();
            int n = Deck.Count;
            while (n > 1)
            {
                byte[] box = new byte[1];
                do Random.GetBytes(box);
                while (!(box[0] < n * (Byte.MaxValue / n)));
                int k = (box[0] % n);
                n--;
                CardModel value = Deck[k];
                Deck[k] = Deck[n];
                Deck[n] = value;
            }
        }
    }
}
