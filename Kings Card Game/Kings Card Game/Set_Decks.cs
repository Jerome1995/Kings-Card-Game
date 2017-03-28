using System;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public partial class SetDecks : Form
    {
        public SetDecks()
        {
            InitializeComponent();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Set_Decks_Load(object sender, EventArgs e)
        {
            setDeckButton.Focus();
        }
    }
}
