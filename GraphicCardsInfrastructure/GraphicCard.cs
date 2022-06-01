using CardModel;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;

namespace GraphicCardInfrasctructure
{
    public class GraphicCard : Card
    {
        private static readonly Image faceDownImage;
        private static readonly Dictionary<Card, Image> cardImages = new Dictionary<Card, Image>();
        public PictureBox CardPicture { get; }

        private bool opened;
        public bool Opened
        {
            get => opened;
            set
            {
                opened = value;
                if (opened)
                    CardPicture.Image = cardImages[this];
                else
                    CardPicture.Image = faceDownImage;
            }
        }
        public GraphicCard(CardColor cardColor, CardFigure cardFigure, PictureBox cardPicture) : base(cardColor, cardFigure)
        {
            CardPicture = cardPicture;
            CardPicture.SizeMode = PictureBoxSizeMode.Zoom;
            CardPicture.Image = faceDownImage;
        }
        public GraphicCard()
        {
            CardPicture = new PictureBox();
            CardPicture.SizeMode = PictureBoxSizeMode.Zoom;
            CardPicture.Image = faceDownImage;
        }
        static GraphicCard()
        {
            faceDownImage = Image.FromFile($"{Application.StartupPath}\\images\\Back.png");
            CardSet full = new CardSet();
            full.Full();

            foreach (Card c in full)
            {
                cardImages[c] = Image.FromFile($"{Application.StartupPath}\\images\\{c.Color} {c.Figure}.png");
            }
        }
        public void Show()
        {
            Opened = true;
        }
        public void Hide()
        {
            Opened = false;
        }
    }
}
