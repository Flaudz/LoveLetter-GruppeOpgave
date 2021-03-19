using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{
    public class DeckModel
    {
        private ObservableCollection<Card> deck;

        public ObservableCollection<Card> Deck { get => deck; set => deck = value; }
    }
}
