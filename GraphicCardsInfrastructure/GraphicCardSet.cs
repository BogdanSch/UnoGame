using CardModel;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicCardInfrasctructure
{
    public class GraphicCardSet : CardSet
    {
        public Panel Panel { get; }
        public GraphicCardSet(Panel panel) : base()
        {
            Panel = panel;
        }
        public GraphicCardSet(Panel panel, params GraphicCard[] cards) : base(cards)
        {
            Panel = panel;
        }
        public GraphicCardSet(Panel panel, List<GraphicCard> cards) : this(panel, cards.ToArray()) { }
        
        public override CardSet GetBlankCardSet()
        {
            return new GraphicCardSet(new Panel());
        }
        public override void Add(params Card[] cards)
        {
            base.Add(cards);
            foreach (Card c in Cards)
            {
                GraphicCard gCard = c as GraphicCard;
                if(gCard != null)
                {
                    Panel.Controls.Add(gCard.CardPicture);
                }
            }
        }
        public override void Remove(Card card)
        {
            GraphicCard gCard = card as GraphicCard;
            if (gCard != null)
                Panel.Controls.Remove(gCard.CardPicture);
            base.Remove(card);
        }
        public override Card GetCard(CardColor suite, CardFigure figure)
        {
            return new GraphicCard(suite, figure, new PictureBox());
        }
        public void Draw()
        {
            for (int i = 0; i < Cards.Count; i++)
            {
                GraphicCard c = Cards[i] as GraphicCard;
                if(c != null)
                {
                    c.CardPicture.BringToFront();
                    c.CardPicture.Size = new Size(c.CardPicture.Image.Width * Panel.Height / c.CardPicture.Image.Height, Panel.Height);
                    c.CardPicture.Location = new Point(i * (Panel.Width - c.CardPicture.Width) / Count, 0);
                }
            }
        }  
        public void ShowCards()
        {
            foreach (GraphicCard c in Cards)
            {
                c.Show();
            }
            Draw();
        }
        public void HideCards()
        {
            foreach (GraphicCard c in Cards)
            {
                c.Hide();
            }
           Draw();
        }
    }
}
