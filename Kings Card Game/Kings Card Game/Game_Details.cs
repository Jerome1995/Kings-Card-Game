using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public partial class Game_Details : Form
    {
        public Game_Details()
        {
            InitializeComponent();
        }

        private Welcome_Screen welcomeFrm = new Welcome_Screen();
        private Kings kingFrm = new Kings();
        private Add_Player addFrm = new Add_Player();

        public void addToDataGrid(string name, DataGridView grid)
        {
            if (name != string.Empty)
            {
                grid.Rows.Add(name);
                grid.Update();
                grid.Visible = true;
            }
        }

        public void AddPlayerDialogBox()
        {
            Add_Player playername = new Add_Player();
            if (playername.ShowDialog(this) == DialogResult.OK)
            {
                addToDataGrid(playername.txtPlayerName.Text,grdPlayer);
            }
            else
            {
                playername.Dispose();
            }
            playername.Dispose();
        }
        public void SetDecksDialogBox()
        {
            Set_Decks deckAmount = new Set_Decks();
            if (deckAmount.ShowDialog(this) == DialogResult.OK)
            {
                if (grdDecks.RowCount > 0)
                {
                    grdDecks.Rows[0].Cells[0].Value = deckAmount.comboDeck.Text;
                }
                addToDataGrid(deckAmount.comboDeck.Text, grdDecks);
                grdDecks.AllowUserToAddRows = false;
            }
            else
            {
                deckAmount.Dispose();
            }
            deckAmount.Dispose();
        }

        public void ExcludeCardsDialogBox()
        {
            Exclude_Cards exCards = new Exclude_Cards();
            if (exCards.ShowDialog(this) == DialogResult.OK)
            {
                addToDataGrid(exCards.comboCard.Text, grdExcludedCards);
                exCards.comboCard.Items.Remove(exCards.comboCard.ToString());
            }
            else
            {
                exCards.Dispose();
            }
            exCards.Dispose();
        }
        

        private void welcomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            welcomeFrm = new Welcome_Screen();
            welcomeFrm.Closed += (s, args) => this.Close();
            welcomeFrm.Show();
        }

        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            AddPlayerDialogBox();
        }

        private void setDecksButton_Click(object sender, EventArgs e)
        {
            SetDecksDialogBox();
        }

        private void excludeCardsButton_Click(object sender, EventArgs e)
        {
            ExcludeCardsDialogBox();
        }

        private void startGameButton_Click(object sender, EventArgs e)
        {

        }
    }
}
