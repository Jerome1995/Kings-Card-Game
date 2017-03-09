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
        //Forms
        private Welcome_Screen welcomeFrm = new Welcome_Screen();
        private Kings kingFrm;

        //Variables
        
        public Game game = new Game();

        //Methods
        public void CreateGame()
        {                
            game.SetPlayers(grdPlayer);
            game.SetDecks(Double.Parse(grdDecks.Rows[0].Cells[0].Value.ToString()));
            game.SetExcludedCards(grdExcludedCards);
            kingFrm = new Kings(game);
            kingFrm.Show();
            Hide();
        }      

        //Events
        private void welcomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            welcomeFrm = new Welcome_Screen();
            welcomeFrm.Closed += (s, args) => this.Close();
            welcomeFrm.Show();
        }
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            game.AddPlayerDialogBox(grdPlayer, this, setDecksButton);
        }
        private void setDecksButton_Click(object sender, EventArgs e)
        {
            game.SetDecksDialogBox(grdDecks, this, excludeCardsButton, startGameButton);
        }
        private void excludeCardsButton_Click(object sender, EventArgs e)
        {
            game.ExcludeCardsDialogBox(grdExcludedCards, this);
        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            CreateGame();
        }
    }
}
