using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{
    public class DeckModel
    {
        private ObservableCollection<CardModel> deck;

        public ObservableCollection<CardModel> Deck { get => deck; set => deck = value; }

        public Deck(ObservableCollection<CardModel> deck)
        {
            deck = Deck;
        }

        //jeg er ikke sikker på om dette virker, siden at det er lidt svært at teste.

        public ObservableCollection<CardModel> DeckCreator()
        {
            ObservableCollection<CardModel> deck = new ObservableCollection<CardModel>();

            for (int i = 1; i < 9; i++)
            {
                CardModel card = new CardModel();
                card.SwitchCase(card,i);
                    for (int o = 0; o < card.NumberOfCards; o++)
                {
                    deck.Add(card);
                }
            }

            return deck;
        }
    }
}
