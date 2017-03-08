using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings_Card_Game
{
   public class Game
    {
       //Variables
        private Players player;
        private Deck deck;

       //Constructors
        public Game()
        {
            this.player = new Players();
            this.deck = new Deck();
        }

        public Game(Deck newDeck, Players newPlayer)
        {
            this.player = newPlayer;
            this.deck = newDeck;
        }

       //Player Methods
        public void AddPlayer(Form form)
        {
            Add_Player playername = new Add_Player();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                player.addPlayer(playername.txtPlayerName.Text);
                MessageBox.Show("Player Added", "The player " + playername.txtPlayerName.Text + " has been added.");
            }
            else
            {
                playername.Dispose();
            }
        }
        public void SetPlayers(DataGridView grid)
        {
            int i = 0;
            while (i < grid.RowCount-1)
            {
                player.addPlayer(grid.Rows[i].Cells[0].Value.ToString());
                i++;
            }
        }
        public string FirstPlayer()
        {
            return player.getPlayer();
        }
        public string NextPlayer(string name)
        {
            return player.nextPlayer(name);
        }
        public void RemovePlayer(Form form)
        {
            Remove_Player playername = new Remove_Player();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                if (player.removePlayer(playername.txtPlayerName.Text))
                {
                    MessageBox.Show("Player Removed", "The player " + playername.txtPlayerName.Text + " has been removed from the game");
                }
                else
                {
                    MessageBox.Show("Error!", "The player " + playername.txtPlayerName.Text + " could not be removed.");
                }
            }
            else
            {
                playername.Dispose();
            }
        }
        public void ChangePlayerName(Form form)
        {
            Change_Player_Name playernames = new Change_Player_Name();
            if (playernames.ShowDialog(form) == DialogResult.OK)
            {
                if (player.changePlayerName(playernames.txtOldName.Text, playernames.txtNewName.Text))
                {
                    MessageBox.Show("Player Name Changed!", "The player name " + playernames.txtOldName.Text + " has been changed to " + playernames.txtNewName.Text);
                }
                else
                {
                    MessageBox.Show("Error!", "The name of player " + playernames.txtOldName.Text + "could not be changed.");
                }
            }
            else
            {
                playernames.Dispose();
            }
        }
        public int PlayerAmount()
        {
            return player.getPlayerAmount();
        }        

       //Deck Methods
        public Card NextCard()
        {
            return deck.getNextCard();
        }
        public void SetDecks(double num)
        {
            deck.setDecks(num);
        }
        public void AddDeck(double num)
        {
            deck.addDeck(num);
            MessageBox.Show("Deck Added", num + " Decks have been added.");
        }
        public void RemoveDeck(double num)
        {
            Boolean result = deck.removeDeck(num);
            if (result)
            {
                MessageBox.Show("Deck Removed", num + " Decks have been removed.");
            }
            else
            {
                MessageBox.Show("Error!", " Decks could not be removed as the number of decks to be removed was greater than the number of decks available.");
            }
        }
        public double NumberOfDecks()
        {
            return deck.getNumberOfDecks();
        }
        public int CardsLeft()
        {
            return deck.getCardsLeft();
        }
        public void ExcludeCard(Form form)
        {
            Exclude_Cards eCard = new Exclude_Cards();
            eCard.comboCard = ShowRemainingCards(eCard.comboCard);
            if (eCard.ShowDialog(form) == DialogResult.OK)
            {
                if (!eCard.comboCard.SelectedItem.Equals(null))
                {
                    Boolean result = deck.excludeCard(eCard.comboCard.SelectedItem.ToString());
                    if (result)
                    {
                        MessageBox.Show("Card Excluded", "All occurences of " + eCard.comboCard.SelectedItem.ToString() + " have been removed.");
                    }
                    else
                    {
                        MessageBox.Show("Error!", "The card " + eCard.comboCard.SelectedItem.ToString() + "could not be removed.");
                    }                    
                }
            }
            else
            {
                eCard.Dispose();
            }
        }
        public void SetExcludedCards(DataGridView grid)
        {
            Boolean result;
            int i = 0;
            while (i < grid.RowCount - 1)
            {
                result = deck.excludeCard(grid.Rows[i].Cells[0].Value.ToString());
                i++;
            }
        }
        public void UndoExclusionOfCard(Form form)
        {
            Undo_Card_Exclusion uCard = new Undo_Card_Exclusion();
            uCard.comboCard = ShowExcludedCards(uCard.comboCard);
            if (uCard.ShowDialog(form) == DialogResult.OK)
            {
                if (!uCard.comboCard.SelectedItem.Equals(null))
                {
                    if (deck.undoExclusion(uCard.comboCard.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Exclusion Undone",
                            "The card " + uCard.comboCard.SelectedItem.ToString() + " has been added back to the deck");
                    }
                    else
                    {
                        MessageBox.Show("Error!",
                            "The card " + uCard.comboCard.SelectedItem.ToString() + " counld not be added back to the deck");
                    }
                }
            }
            else
            {
                uCard.Dispose();
            }
        }

        public ComboBox ShowRemainingCards(ComboBox combo)
        {
            int i = 0;
            foreach (string x in deck.remainingCards())
            {
                combo.Items.Insert(i, x);
                i++;
            }
            return combo;
        }           //internal
        public ComboBox ShowExcludedCards(ComboBox combo)
        {
            int i = 0;
            foreach (string x in deck.getExcludedCards())
            {
                combo.Items.Insert(i, x);
                i++;
            }
            return combo;
        }            //internal
       
       //Game Methods
        public string RestartGame()
        {
            Boolean result = deck.restartGame();
            if (result)
            {
                MessageBox.Show("Game Reset", "The game and the decks have been reset");
                return FirstPlayer();
            }
            else
            {
                MessageBox.Show("Error!", "The game has not been reset");
                return "Unknown";
            }
        }
    }
}
