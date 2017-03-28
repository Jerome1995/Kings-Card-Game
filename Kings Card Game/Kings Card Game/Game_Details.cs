using System;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public partial class GameDetails : Form
    {
        public GameDetails()
        {
            InitializeComponent();
        }
        //Forms
        private WelcomeScreen _welcomeFrm = new WelcomeScreen();
        private Kings _kingFrm;

        //Variables
        
        public Game Game = new Game();

        //Methods
        public void CreateGame()
        {                
            Game.SetPlayers(grdPlayer);
            Game.SetDecks(Double.Parse(grdDecks.Rows[0].Cells[0].Value.ToString()));
            Game.SetExcludedCards(grdExcludedCards);
            _kingFrm = new Kings(Game);
            _kingFrm.Show();
            Hide();
        }      

        //Events
        private void welcomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            _welcomeFrm = new WelcomeScreen();
            _welcomeFrm.Closed += (s, args) => Close();
            _welcomeFrm.Show();
        }
        private void addPlayerButton_Click(object sender, EventArgs e)
        {
            Game.AddPlayerDialogBox(grdPlayer, this, setDecksButton);
        }
        private void setDecksButton_Click(object sender, EventArgs e)
        {
            Game.SetDecksDialogBox(grdDecks, this, excludeCardsButton, startGameButton);
        }
        private void excludeCardsButton_Click(object sender, EventArgs e)
        {
            Game.ExcludeCardsDialogBox(grdExcludedCards, this);
        }
        private void startGameButton_Click(object sender, EventArgs e)
        {
            CreateGame();
        }
    }
}
