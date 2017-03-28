using System;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            GameDetails frm = new GameDetails();
            frm.Show();
            Hide();
            frm.Closed += (s, args) => Close();
            frm.Show();
        }
    }
}
