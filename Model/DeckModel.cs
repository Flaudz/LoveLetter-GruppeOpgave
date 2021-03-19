using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using LoveLetter_GruppeOpgave.Model;

namespace LoveLetter_GruppeOpgave.Model
{
    public class DeckModel
    {
        private ObservableCollection<Card> deck;

        public ObservableCollection<Card> Deck { get => deck; set => deck = value; }

        public DeckModel GetDeck()
        {
            // Making all cards
            List<Card> cards = new List<Card>();
            cards.Add(new Card { Id = 1, Name = "Guard", NumberOfCard = 1 });
            cards.Add(new Card { Id = 2, Name = "Guard", NumberOfCard = 1 });
            cards.Add(new Card { Id = 3, Name = "Guard", NumberOfCard = 1 });
            cards.Add(new Card { Id = 4, Name = "Guard", NumberOfCard = 1 });
            cards.Add(new Card { Id = 5, Name = "Guard", NumberOfCard = 1 });
            cards.Add(new Card { Id = 6, Name = "Priest", NumberOfCard = 2 });
            cards.Add(new Card { Id = 7, Name = "Priest", NumberOfCard = 2 });
            cards.Add(new Card { Id = 8, Name = "Baron", NumberOfCard = 3 });
            cards.Add(new Card { Id = 9, Name = "Baron", NumberOfCard = 3 });
            cards.Add(new Card { Id = 10, Name = "Handmaid", NumberOfCard = 4 });
            cards.Add(new Card { Id = 11, Name = "Handmaid", NumberOfCard = 4 });
            cards.Add(new Card { Id = 12, Name = "Prince", NumberOfCard = 5 });
            cards.Add(new Card { Id = 13, Name = "Prince", NumberOfCard = 5 });
            cards.Add(new Card { Id = 14, Name = "King", NumberOfCard = 6 });
            cards.Add(new Card { Id = 15, Name = "Countess", NumberOfCard = 7 });
            cards.Add(new Card { Id = 16, Name = "Princess", NumberOfCard = 8 });
            // Randomly Order it by Guid..
            cards = cards.OrderBy(i => Guid.NewGuid()).ToList();
            // It's now shuffled.
            ObservableCollection<Card> cardCollection = new ObservableCollection<Card>(cards);

            return cardCollection;
        }
    }
}
