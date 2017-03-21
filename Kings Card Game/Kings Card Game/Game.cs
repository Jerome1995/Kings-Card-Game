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

        public Game(string newPlayer, double numDeck, int cardsLeft, Card card, 
            List<String> exCards, List<string> playerList, string cardname, string rule, string path)
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
       
       //Game Methods
        public string RestartGame()
        {
            Boolean result = ResetGameDetails();
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
