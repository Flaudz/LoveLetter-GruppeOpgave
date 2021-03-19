using System;
using System.Collections.Generic;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{

    public class Card
    {
        private int id;
        private string name;
        private int numberOfCards;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public int NumberOfCards { get => numberOfCards; set => numberOfCards = value; }
    }
}
