using System;
using System.Windows.Forms;
using Kings_Card_Game.Properties;

namespace Kings_Card_Game
{
    public partial class Kings : Form
    {
        //Constructors
        public Kings(Game game)
        {
            InitializeComponent();
            _game = game;
        }
        
        //Variables
        private Game _game;

        //Methods
        public void CardDetails()
        {
            txtCardName.Text = _game.GetCardName();
            txtCardRule.Text = _game.GetCardRule();
            txtCardsLeft.Text = _game.CardsLeft().ToString();
            // ReSharper disable once SpecifyACultureInStringConversionExplicitly
            txtDecksLeft.Text = _game.NumberOfDecks().ToString();
            cardBox.ImageLocation = @"Images\" + _game.GetImagePath() + Resources.PNG;
        }
        public void PlayerDetails()
        {
            txtPlayerName.Text = _game.NextPlayer(txtPlayerName.Text);
            txtPlayerAmount.Text = _game.PlayerAmount().ToString();
        }

        //Events
        private void Kings_Load(object sender, EventArgs e)
        {
            _game.NextCard();
            CardDetails();
            txtPlayerName.Text = _game.FirstPlayer();
            txtPlayerAmount.Text = _game.PlayerAmount().ToString();
            
            cardBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
        private void nextCardButton_Click(object sender, EventArgs e)
        {
            _game.NextCard();
            CardDetails();
            PlayerDetails();
        }
        private void welcomeScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            WelcomeScreen frm = new WelcomeScreen();
            _game = new Game();
            frm.Show();

        }
        private void gameDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Hide();
            GameDetails frm = new GameDetails();
            _game = new Game();
            frm.Show();
        }
        private void addPlayerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _game.AddPlayer(this);
        }
        private void removePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.RemovePlayer(this);
        }
        private void changePlayerNameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.ChangePlayerName(this);
        }
        private void halfDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.AddDeck(0.5);
            CardDetails();
        }
        private void oneDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.AddDeck(1);
            CardDetails();
        }
        private void twoDeckToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.AddDeck(2);
            CardDetails();
        }
        private void chooseCardToolStripMenuItem_Click(object sender, EventArgs e)
        {
           _game.ExcludeCard(this);
           CardDetails();
        }
        private void undoExclusionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _game.UndoExclusionOfCard(this);
            CardDetails();
        }
        private void restartGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtPlayerName.Text = _game.RestartGame();
            CardDetails();
        }





        

       
    }
}
