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
        //Constructors
        public Kings(Game game)
        {
            InitializeComponent();
            this.game = game;
        }
        
        //Variables
        private Game game;

        //Methods
        public void CardDetails()
        {
            txtCardName.Text = game.getCardName();
            txtCardRule.Text = game.getCardRule();
            txtCardsLeft.Text = game.CardsLeft().ToString();
            txtDecksLeft.Text = game.NumberOfDecks().ToString();
            cardBox.ImageLocation = @"Images\" + game.getImagePath() + ".png";
        }
        public void PlayerDetails()
        {
            txtPlayerName.Text = game.NextPlayer(txtPlayerName.Text);
            txtPlayerAmount.Text = game.PlayerAmount().ToString();
        }

        //Events
        private void Kings_Load(object sender, EventArgs e)
        {
            game.NextCard();
            CardDetails();
            txtPlayerName.Text = game.FirstPlayer();
            txtPlayerAmount.Text = game.PlayerAmount().ToString();
            
            cardBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void nextCardButton_Click(object sender, EventArgs e)
        {
            game.NextCard();
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
            game.AddPlayer(this);
        }
        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.RemovePlayer(this);
        }
        private void changePlayerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.ChangePlayerName(this);
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
           game.ExcludeCard(this);
           CardDetails();
        }
        private void undoExclusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            game.UndoExclusionOfCard(this);
            CardDetails();
        }
        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPlayerName.Text = game.RestartGame();
            CardDetails();
        }





        

       
    }
}
