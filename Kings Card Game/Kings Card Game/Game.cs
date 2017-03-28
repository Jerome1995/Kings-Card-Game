using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Kings_Card_Game.Properties;

namespace Kings_Card_Game
{
   public class Game : Players
    {
       //Variables
        private readonly List<string> _selectedCards = new List<string>();

       //Constructors
        public Game()
        {
            SetPlayerName("");
            SetCardName("");
            SetCardRule("");
            SetImagePath("");
            SetNumberOfDecks(0);
            SetCardsLeft(0);
            SetExcludedCards(new List<string>());
            SetPlayerList(new List<string>());
        }

        public Game(string newPlayer, double numDeck, int cardsLeft, 
            List<String> exCards, List<string> playerList, string cardname, string rule, string path)
        {
            SetPlayerName(newPlayer);
            SetCardName(cardname);
            SetCardRule(rule);
            SetImagePath(path);
            SetNumberOfDecks(numDeck);
            SetCardsLeft(cardsLeft);
            SetExcludedCards(exCards);
            SetPlayerList(playerList);
            
        }       
       
       //Game Methods
        public string RestartGame()
        {
            Boolean result = ResetGameDetails();
            if (result)
            {
                MessageBox.Show(Resources.Game_Reset_Header, Resources.Game_Reset_Confirm);
                return FirstPlayer();
            }
            MessageBox.Show(Resources.Error, Resources.Game_Reset_Fail);
            return "Unknown";
        }
        public void AddToDataGrid(string name, DataGridView grid)
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
            AddPlayer playername = new AddPlayer();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                if (playername.txtPlayerName.Text.Equals(""))
                {
                    MessageBox.Show(Resources.Valid_Name_Fail);
                }
                else
                {
                    AddToDataGrid(playername.txtPlayerName.Text, grid);
                    button.Visible = true;
                }                
            }
            else
            {
                playername.Dispose();
            }
        }
        public void SetDecksDialogBox(DataGridView grid, Form form, Button buttonOne, Button buttonTwo)
        {
            SetDecks deckAmount = new SetDecks();
            if (deckAmount.ShowDialog(form) == DialogResult.OK)
            {
                if (deckAmount.comboDeck.Text.Equals(""))
                {
                    MessageBox.Show(Resources.Valid_Number_Of_Decks_Fail);
                }
                else
                {
                    if (grid.RowCount > 0)
                    {
                        grid.Rows[0].Cells[0].Value = deckAmount.comboDeck.Text;
                        buttonOne.Visible = true;
                        buttonTwo.Visible = true;
                    }
                    AddToDataGrid(deckAmount.comboDeck.Text, grid);
                    grid.AllowUserToAddRows = false; 
                }                               
            }
            else
            {
                deckAmount.Dispose();
            }
        }
        public void ExcludeCardsDialogBox(DataGridView grid, Form form)
        {
            ExcludeCards exCards = new ExcludeCards();
            
            if (exCards.ShowDialog(form) == DialogResult.OK)
            {
                if (_selectedCards.Contains(exCards.comboCard.Text) == false)
                {
                    _selectedCards.Add(exCards.comboCard.Text);
                    AddToDataGrid(exCards.comboCard.Text, grid);                    
                } 
            }
            else
            {
                exCards.Dispose();
            }
        }
        
    }
}
