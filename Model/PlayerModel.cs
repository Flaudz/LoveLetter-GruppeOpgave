using System;
using System.Collections.Generic;
using System.Text;

namespace LoveLetter_GruppeOpgave.Model
{

    public class Player
    {
        private int id;
        private string name;
        private List<Card> onHand;
        private Card lastThrownCard;

        public int Id { get => id; set => id = value; }
        public string Name { get => name; set => name = value; }
        public List<Card> OnHand { get => onHand; set => onHand = value; }
        public Card LastThrownCard { get => lastThrownCard; set => lastThrownCard = value; }
    }

}
