using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;

namespace CardModel
{
    [XmlInclude(typeof(CardSet))]
    [Serializable]
    public class CardSet : IEnumerable<Card>
    {
        protected List<Card> Cards { get; set; }
        public int Count { get => Cards.Count; }
        public Card LastCard { get => Cards[Count - 1]; }
        public Card this[int i]
        {
            get => Cards[i];
            set => Cards[i] = value;
        }

        private static readonly Random rnd = new Random();

        public CardSet(List<Card> cards)
        {
            Cards = cards;
        }
        public CardSet() : this(new List<Card>()) { }
        public CardSet(params Card[] cards) : this(new List<Card>(cards)) { }

        public Card Pull(int number = 0)
        {
            if (number < 0 || number >= Count) 
                throw new Exception("The number of cards was out the range");

            Card card = Cards[number];
            Remove(card);

            return card;
        }
        public Card Pull(Card card)
        {
            Card foundCard = Cards.FirstOrDefault(c => c.Equals(card));
            if (!(foundCard == null)) Remove(foundCard);

            return foundCard;
        }
        public CardSet Deal(int amount)
        {
            if (amount < 0)
                throw new Exception("Amount of cards must be more than zero!");

            if (amount > Count) amount = Count;

            CardSet cards = GetBlankCardSet();
            for (int i = 0; i < amount; i++)
            {
                cards.Add(Pull());
            }
            return cards;
        }
        public virtual CardSet GetBlankCardSet()
        {
            return new CardSet();
        }
        public virtual void Add(params Card[] cards)
        {
            Cards.AddRange(cards);
        }
        public void Add(object obj)
        {
            Card card = obj as Card;

            if (card != null) Add(card);
            else throw new Exception("Not valid");
        }
        public void Add(List<Card> cards)
        {
            Add(cards.ToArray());
        }
        public void Add(CardSet cards)
        {
            Add(cards.Cards);
        }
        public virtual void Remove(Card card)
        {
            Cards.Remove(card);
        }
        public void Remove(int number)
        {
            if (number < 0 || number > Count)
                throw new Exception("Incorrect number");
            Remove(Cards[number]);
        }
        public void Full()
        {
            foreach (CardColor color in Enum.GetValues(typeof(CardColor)))
            {
                if (color == CardColor.Black)
                    continue;
                foreach (CardFigure figure in Enum.GetValues(typeof(CardFigure)))
                {
                    if (figure == CardFigure.SquadCards || figure == CardFigure.ColorSwitcher)
                        continue;
                    Add(GetCard(color, figure));
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Add(GetCard(CardColor.Black, CardFigure.ColorSwitcher));
            }
            for (int i = 0; i < 4; i++)
            {
                Add(GetCard(CardColor.Black, CardFigure.SquadCards));
            }
        }
        public virtual Card GetCard(CardColor color, CardFigure figure)
        {
            return new Card(color, figure);
        }
        public void Sort()
        {
            Cards.Sort(
                (card1, card2) => card1.Figure.CompareTo(card2.Figure) == 0 ?
                    card1.Color.CompareTo(card2.Color) :
                    card1.Figure.CompareTo(card2.Figure)
            );
        }
        public void Shuffle()
        {
            for (int j = 0; j < 4; j++)
            {
                for (int i = 0; i < Count; i++)
                {
                    int randNum = rnd.Next(Count);
                    Card temp = Cards[i];
                    Cards[i] = Cards[randNum];
                    Cards[randNum] = temp;
                }
            }
        }
        public void CutTo(int amount)
        {
            while (Count > amount)
                Remove(0);
        }
        public void Clear()
        {
            CutTo(0);
        }
        public IEnumerator<Card> GetEnumerator() => Cards.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => Cards.GetEnumerator();
    }
}
