using CardModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnoForm
{
    public partial class ChooseColorForm : Form 
    {
        public CardColor ChosedColor;
        public Color PicColor = Color.Green;

        public ChooseColorForm()
        {
            InitializeComponent();
        }

        private void ColorPictureClick(object sender, EventArgs e)
        {
            PictureBox pictureBox = sender as PictureBox;

            if(pictureBox != null)
            {
                if (pictureBox.BackColor == Color.Green)
                    ChosedColor = CardColor.Green;
                else if (pictureBox.BackColor == Color.Blue)
                    ChosedColor = CardColor.Blue;
                else if (pictureBox.BackColor == Color.Red)
                    ChosedColor = CardColor.Red;
                else if(pictureBox.BackColor == Color.Yellow)
                    ChosedColor= CardColor.Yellow;

                PicColor = pictureBox.BackColor;
                Hide();
            }
        }
    }
}
