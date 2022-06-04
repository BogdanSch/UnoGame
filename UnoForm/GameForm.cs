using CardModel;
using GraphicCardInfrasctructure;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using UnoLogic;

namespace UnoForm
{
    public partial class GameForm : Form
    {
        GraphicCard ActiveCard;
        public static UnoGame Game;
        Dictionary<PictureBox, GraphicCard> CardsPictures = new Dictionary<PictureBox, GraphicCard>();

        public GameForm()
        {
            InitializeComponent();
            pbActiveCard.BringToFront();
            NewGame();
        }

        private void NewGame()
        {
            List<Player> players = new List<Player>()
            {
                //new Player(StartUpForm.playersNames[0], new GraphicCardSet(pPlr1)),
                //new Player(StartUpForm.playersNames[1], new GraphicCardSet(pPlr2)),
                //new Player(StartUpForm.playersNames[2], new GraphicCardSet(pPlr3)),
                //new Player(StartUpForm.playersNames[3], new GraphicCardSet(pPlr4)),
                new Player("Bogdan", new GraphicCardSet(pPlr1)),
                new Player("Igor", new GraphicCardSet(pPlr2)),
                new Player("Alex", new GraphicCardSet(pPlr3)),
                new Player("Yana", new GraphicCardSet(pPlr4)),
            };

            Game = new UnoLogic.UnoGame(players, ShowState, ChangeColor);
            Game.Deck = new GraphicCardSet(pDeck);
            Game.Table = new GraphicCardSet(pTable);
            Game.Prepare();
            BindPictureBoxes();
            Game.Deal();
        }
        private CardColor ChangeColor()
        {
            CardColor targetColor;

            ChooseColorForm form = new ChooseColorForm();
            form.ShowDialog();

            targetColor = form.ChosedColor;
            picColor.BackColor = form.PicColor;

            form.Close();
            return targetColor;
        }
        private void ShowState()
        {
            ShowOrHide(Game.Table, true);
            ShowOrHide(Game.Deck, false);
            foreach (Player player in Game.Players)
            {
                ShowOrHide(player.Hand, player == Game.ActivePlayer);
            }
            if (Game.IsGameOver) 
            {
                lInfo.Text = $"{Game.ResultInfo}";
                return;
            }
            lInfo.Text = $"{Game.ResultInfo}... {Game.StateInfo}";

            string action = Game.GetPossibleActions();

            bBluff.Enabled = action.Contains("Bluff") && !Game.IsGameOver;
        }
        private void ShowOrHide(CardSet set, bool isOpen)
        {
            GraphicCardSet gSet = set as GraphicCardSet;

            if (gSet != null)
            {
                if (isOpen)
                    gSet.ShowCards();
                else
                    gSet.HideCards();
            }
        }
        private void BindPictureBoxes()
        {
            foreach (var card in Game.Deck)
            {
                GraphicCard gCard = card as GraphicCard;
                if (gCard != null)
                {
                    CardsPictures[gCard.CardPicture] = gCard;
                    gCard.CardPicture.MouseDown += SelectCard;
                    gCard.CardPicture.MouseMove += MoveCard;
                    gCard.CardPicture.MouseUp += AttemdOfTurn;
                }
            }
        }
        private void MoveCard(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left) return;
            if (ActiveCard == null) return;
            pbActiveCard.Location = new Point(Cursor.Position.X - Location.X - pbActiveCard.Width, Cursor.Position.Y - Location.Y - pbActiveCard.Height);
        }
        private void SelectCard(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;

            if (pb != null)
            {
                ActiveCard = CardsPictures[pb];
                pbActiveCard.Image = pb.Image;
                pbActiveCard.Show();
                pbActiveCard.Location = new Point(Cursor.Position.X - Location.X - pbActiveCard.Width, Cursor.Position.Y - Location.Y - pbActiveCard.Height);
            }
        }
        private void AttemdOfTurn(object sender, MouseEventArgs e)
        {
            if (ActiveCard == null) return;
            if (e.Button != MouseButtons.Left) return;
            Rectangle r1 = new Rectangle(pbActiveCard.Location, pbActiveCard.Size);
            Rectangle r2 = new Rectangle(
                new Point(pTable.Parent.Location.X + pTable.Location.X, pTable.Parent.Location.Y + pTable.Location.Y) ,
                pTable.Size
            );

            if (r1.IntersectsWith(r2)) Game.Turn(ActiveCard);
            ActiveCard = null;
            pbActiveCard.Hide();
        }
        private void bPass_Click(object sender, EventArgs e)
        {
            Game.Pass();
        }
        private void bBluff_Click(object sender, EventArgs e)
        {
            Game.Bluff();
        }
        private void UnoGameForm_Closing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}