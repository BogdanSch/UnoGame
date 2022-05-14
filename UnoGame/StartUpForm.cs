using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace UnoGame
{
    public partial class StartUpForm : Form
    {
        public static List<string> playersNames;
        public StartUpForm()
        {
            InitializeComponent();
        }

        private void bPlay_Click(object sender, EventArgs e)
        {
            playersNames = new List<string>();

            playersNames.Add(tPlayer1.Text.Trim());
            playersNames.Add(tPlayer2.Text.Trim());
            playersNames.Add(tPlayer3.Text.Trim());
            playersNames.Add(tPlayer4.Text.Trim());

            GameForm form = new GameForm();

            Hide();
            form.Show();
        }
    }
}
