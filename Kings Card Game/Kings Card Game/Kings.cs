using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public partial class Kings : Form
    {
        public Kings(Game game)
        {
            InitializeComponent();
            this.game = game;
        }
        
        private Game game;
        private Card card;

        public void CardDetails()
        {
            txtCardName.Text = card.getCardName();
            txtCardRule.Text = card.getCardRule();
            txtCardsLeft.Text = game.CardsLeft().ToString();
            txtDecksLeft.Text = game.NumberOfDecks().ToString();
            cardBox.ImageLocation = @"Images\" + card.getImagePath() + ".png";
        }
        public void PlayerDetails()
        {
            txtPlayerName.Text = game.NextPlayer(txtPlayerName.Text);
            txtPlayerAmount.Text = game.PlayerAmount().ToString();
        }

        private void Kings_Load(object sender, EventArgs e)
        {
            card = game.NextCard();
            CardDetails();
            txtPlayerName.Text = game.FirstPlayer();
            txtPlayerAmount.Text = game.PlayerAmount().ToString();
            
            cardBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private void nextCardButton_Click(object sender, EventArgs e)
        {
            card = game.NextCard();
            CardDetails();
            PlayerDetails();
        }

        private void welcomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Welcome_Screen frm = new Welcome_Screen();
            game = new Game();
            frm.Show();

        }

        private void gameDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            Game_Details frm = new Game_Details();
            game = new Game();
            frm.Show();
        }

        private void addPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Add_Player playername = new Add_Player();
            if (playername.ShowDialog(this) == DialogResult.OK)
            {
                game.AddPlayer(playername.txtPlayerName.Text);
            }
            else
            {
                playername.Dispose();
            }
        }

        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Remove_Player playername = new Remove_Player();
            if (playername.ShowDialog(this) == DialogResult.OK)
            {
                game.RemovePlayer(playername.txtPlayerName.Text);
            }
            else
            {
                playername.Dispose();
            }
        }

        private void changePlayerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Change_Player_Name player = new Change_Player_Name();
            if (player.ShowDialog(this) == DialogResult.OK)
            {
                game.ChangePlayerName(player.txtOldName.Text,player.txtNewName.Text);
            }
            else
            {
                player.Dispose();
            }
        }

        private void halfDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.AddDeck(0.5);
            CardDetails();
        }

        private void oneDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.AddDeck(1);
            CardDetails();
        }

        private void twoDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.AddDeck(2);
            CardDetails();
        }

        private void chooseCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exclude_Cards eCard = new Exclude_Cards();
            eCard.comboCard = game.ShowRemainingCards(eCard.comboCard);
            if (eCard.ShowDialog(this) == DialogResult.OK)
            {
                if (!eCard.comboCard.SelectedItem.Equals(null))
                {
                    game.ExcludeCard(eCard.comboCard.SelectedItem.ToString());
                    CardDetails();
                }
            }
            else
            {
                eCard.Dispose();
            }

        }

        private void undoExclusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Undo_Card_Exclusion uCard = new Undo_Card_Exclusion();
            uCard.comboCard = game.ShowExcludedCards(uCard.comboCard);
            if (uCard.ShowDialog(this) == DialogResult.OK)
            {
                if (!uCard.comboCard.SelectedItem.Equals(null))
                {
                    game.UndoExclusionOfCard(uCard.comboCard.SelectedItem.ToString());
                    CardDetails();
                }
            }
            else
            {
                uCard.Dispose();
            }
        }

        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPlayerName.Text = game.RestartGame();
            CardDetails();
            PlayerDetails();
        }





        

       
    }
}
