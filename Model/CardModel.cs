using System;
using System.Collections.Generic;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{

    public class CardModel
    {
        private int id;
        private string name;
        private int numberOfCards;
        private string description;
        private string picture;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfCards { get => numberOfCards; set => numberOfCards = value; }
        public string Description { get => description; set => description = value;}
        public string Picture { get => picture; set => picture = value;}

        public Card(int id, string name, int numberOfCards, string description, string picture)
        {
            id = Id;
            name = Name;
            numberOfCards = NumberOfCards;
            description = Description;
            picture = Picture;
        }

        //jeg ved ikke om dette virker, siden det er lidt svært at teste det.

        public CardModel SwitchCase(CardModel card, int i)
        {
            if (i == 1)
            {
                CardModel newCard = Guard(card);
                return newCard;
            }
            else if (i == 2)
            {
                CardModel newCard = Priest(card);
                return newCard;
            }
            else if (i == 3)
            {
                CardModel newCard = Baron(card);
                return newCard;
            }
            else if (i == 4)
            {
                CardModel newCard = Handmaiden(card);
                return newCard;
            }
            else if (i == 5)
            {
                CardModel newCard = Prince(card);
                return newCard;
            }
            else if (i == 6)
            {
                CardModel newCard = King(card);
                return newCard;
            }
            else if (i == 7)
            {
                CardModel newCard = Countess(card);
                return newCard;
            }
            else if (i == 8)
            {
                CardModel newCard = Princess(card);
                return newCard;
            }
            else
            {
                CardModel newCard = ErrorCard(card);
                return newCard;
            }
                
        }

        public CardModel Guard(CardModel card)
        {
            int id = 1;
            string name = "Guard";
            int numberOfCopies = 5;
            string description = "";
            string picture = "";
            
            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
        }
        public CardModel Priest(CardModel card)
        {
            int id = 2;
            string name = "Priest";
            int numberOfCopies = 2;
            string description = "";
            string picture = "";

            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
        }
        public CardModel Baron(CardModel card)
        {
            int id = 3;
            string name = "Baron";
            int numberOfCopies = 2;
            string description = "";
            string picture = "";

            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
        }
        public CardModel Handmaiden(CardModel card)
        {
            int id = 4;
            string name = "Handmaiden";
            int numberOfCopies = 2;
            string description = "";
            string picture = "";

            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
        }
        public CardModel Prince(CardModel card)
        {
            int id = 5;
            string name = "Prince";
            int numberOfCopies = 2;
            string description = "";
            string picture = "";

            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
        }
        public CardModel King(CardModel card)
        {
            int id = 6;
            string name = "King";
            int numberOfCopies = 1;
            string description = "";
            string picture = "";

            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
        }
        public CardModel Countess(CardModel card)
        {
            int id = 7;
            string name = "Countess";
            int numberOfCopies = 1;
            string description = "";
            string picture = "";

            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
        }
        public CardModel Princess(CardModel card)
        {
            int id = 8;
            string name = "Princess";
            int numberOfCopies = 1;
            string description = "";
            string picture = "";

            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
        }
        public CardModel ErrorCard(CardModel card)
            {
            int id = 0;
            string name = "Error";
            int numberOfCopies = 1;
            string description = "";
            string picture = "";

            card.Id = id;
            card.Name = name;
            card.NumberOfCards = numberOfCopies;
            card.Description = description;
            card.Picture = picture;

            return card;
            }
    }
}
