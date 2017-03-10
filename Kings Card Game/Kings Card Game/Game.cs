using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings_Card_Game
{
   public class Game : Players
    {
       //Variables
        private List<string> selectedCards = new List<string>();

       //Constructors
        public Game()
        {
            setPlayerName("");
            setCardName("");
            setCardRule("");
            setImagePath("");
            setNumberOfDecks(0);
            setCardsLeft(0);
            setExcludedCards(new List<string>());
            setPlayerList(new List<string>());
        }

        public Game(string newPlayer, double numDeck, int cardsLeft, Card card, List<String> exCards, List<string> playerList, string cardname, string rule, string path)
        {
            setPlayerName(newPlayer);
            setCardName(cardname);
            setCardRule(rule);
            setImagePath(path);
            setNumberOfDecks(numDeck);
            setCardsLeft(cardsLeft);
            setExcludedCards(exCards);
            setPlayerList(playerList);
            
        }

       //Player Methods
        public void AddPlayer(Form form)
        {
            Add_Player playername = new Add_Player();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                addPlayer(playername.txtPlayerName.Text);
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
                addPlayer(grid.Rows[i].Cells[0].Value.ToString());
                i++;
            }
        }
        public string FirstPlayer()
        {
            return getPlayer();
        }
        public string NextPlayer(string name)
        {
            return nextPlayer(name);
        }
        public void RemovePlayer(Form form)
        {
            Remove_Player playername = new Remove_Player();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                if (removePlayer(playername.txtPlayerName.Text))
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
                if (changePlayerName(playernames.txtOldName.Text, playernames.txtNewName.Text))
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
            return getPlayerAmount();
        }        

       //Deck Methods
        public void NextCard()
        {
            getNextCard();
        }
        public void SetDecks(double num)
        {
            setDecks(num);
        }
        public void AddDeck(double num)
        {
            addDeck(num);
            MessageBox.Show("Deck Added", num + " Decks have been added.");
        }
        public void RemoveDeck(double num)
        {
            Boolean result = removeDeck(num);
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
            return getNumberOfDecks();
        }
        public int CardsLeft()
        {
            return getCardsLeft();
        }
        public void ExcludeCard(Form form)
        {
            Exclude_Cards eCard = new Exclude_Cards();
            eCard.comboCard = ShowRemainingCards(eCard.comboCard);
            if (eCard.ShowDialog(form) == DialogResult.OK)
            {
                if (!eCard.comboCard.SelectedItem.Equals(null))
                {
                    Boolean result = excludeCard(eCard.comboCard.SelectedItem.ToString());
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
                result = excludeCard(grid.Rows[i].Cells[0].Value.ToString());
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
                    if (undoExclusion(uCard.comboCard.SelectedItem.ToString()))
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
            foreach (string x in remainingCards())
            {
                combo.Items.Insert(i, x);
                i++;
            }
            return combo;
        }           //internal
        public ComboBox ShowExcludedCards(ComboBox combo)
        {
            int i = 0;
            foreach (string x in getExcludedCards())
            {
                combo.Items.Insert(i, x);
                i++;
            }
            return combo;
        }            //internal
       
       //Game Methods
        public string RestartGame()
        {
            Boolean result = restartGame();
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
        public void addToDataGrid(string name, DataGridView grid)
        {
            if (name != string.Empty)
            {
                grid.Rows.Add(name);
                grid.Update();
                grid.Visible = true;
            }
        }
        public void AddPlayerDialogBox(DataGridView grid, Form form, Button button)
        {
            Add_Player playername = new Add_Player();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                addToDataGrid(playername.txtPlayerName.Text,grid);
                button.Visible = true;
            }
            else
            {
                playername.Dispose();
            }
        }
        public void SetDecksDialogBox(DataGridView grid, Form form, Button buttonOne, Button buttonTwo)
        {
            Set_Decks deckAmount = new Set_Decks();
            if (deckAmount.ShowDialog(form) == DialogResult.OK)
            {
                if (grid.RowCount > 0)
                {
                    grid.Rows[0].Cells[0].Value = deckAmount.comboDeck.Text;
                    buttonOne.Visible = true;
                    buttonTwo.Visible = true;
                }
                addToDataGrid(deckAmount.comboDeck.Text, grid);
                grid.AllowUserToAddRows = false;                
            }
            else
            {
                deckAmount.Dispose();
            }
        }
        public void ExcludeCardsDialogBox(DataGridView grid, Form form)
        {
            Exclude_Cards exCards = new Exclude_Cards();
            
            if (exCards.ShowDialog(form) == DialogResult.OK)
            {
                if (selectedCards.Contains(exCards.comboCard.Text) == false)
                {
                    selectedCards.Add(exCards.comboCard.Text);
                    addToDataGrid(exCards.comboCard.Text, grid);                    
                } 
            }
            else
            {
                exCards.Dispose();
            }
        }
        
    }
}
