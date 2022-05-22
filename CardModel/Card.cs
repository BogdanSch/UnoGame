using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardModel
{
    public class Card
    {
        public Card(CardColor cardSuite, CardFigure cardFigure)
        {
            Color = cardSuite;
            Figure = cardFigure;
        }
        public Card() { }
        public CardColor Color { get; set; }
        public CardFigure Figure { get; set; }

        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            if (!(obj is Card)) return false;

            return Equals((Card)obj);
        }
        public bool Equals(Card other)
        {
            if (other == null) return false;
            if (other.Color == Color && other.Figure == Figure) return true;
            return false;
        }
        public override int GetHashCode()
        {
            return 0;
        }
        public override string ToString()
        {
            return $"{Color} {Figure}";
        }
    }
}
