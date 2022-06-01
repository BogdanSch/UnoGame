using CardModel;
using System;
using System.Xml.Serialization;

namespace UnoLogic
{
    [XmlInclude(typeof(Player))]
    [Serializable]
    public class Player
    {
        public Player(string name, CardSet hand)
        {
            Name = name;
            Hand = hand;
        }
        public Player(string name) : this(name, new CardSet()) { }
        public Player() : this("Unknown") { }

        public string Name { get; set; }
        public CardSet Hand { get; set; }
        public bool IsInGame { get; set; } = true;
        public bool Uno { get; set; } = false;
    }
}
