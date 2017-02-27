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
            card = game.NextCard();
            txtCardName.Text = card.getCardName();
            txtCardRule.Text = card.getCardRule();
            txtCardsLeft.Text = game.CardsLeft().ToString();
            txtDecksLeft.Text = game.NumberOfDecks().ToString();
        }
        public void PlayerDetails()
        {
            txtPlayerName.Text = game.NextPlayer(txtPlayerName.Text);
            txtPlayerAmount.Text = game.PlayerAmount().ToString();
        }

        private void Kings_Load(object sender, EventArgs e)
        {
            CardDetails();
            txtPlayerName.Text = game.FirstPlayer();
            txtPlayerAmount.Text = game.PlayerAmount().ToString();
        }

        private void nextCardButton_Click(object sender, EventArgs e)
        {
            CardDetails();
            PlayerDetails();
        }



        

       
    }
}
