using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public abstract class Players : Deck
    {
        //Variables
        private string playerName;
        private List<String> playerList = new List<string>();
        private int i = 0;

        //Setters
        public void setPlayerName(string name)
        {
            this.playerName = name;
        }
        public void setPlayerList(List<string> list)
        {
            this.playerList = list;
        }
        //Getters 
        public string getPlayerName()
        {
            return playerName;
        }
        public List<string> getPlayerList()
        {
            return playerList;
        }

        //Methods
        public void addPlayerToList(string name)
        {
            string dupName = name;
            i = 0;
            int num = 1;
            while (i <= playerList.Count)
            {
                int count = playerList.Count(j => j.Equals(dupName));
                if (count == 0)
                {
                    playerList.Add(dupName);
                    i = playerList.Count + 1;
                }
                else
                {
                    num++;
                    dupName = name + "_" + num;
                }
            }            
        }
        public string FirstPlayer()
        {
            playerName = playerList[0];
            return playerName;
        }
        public string NextPlayer(string previouisName)
        {
            if (playerList.Contains(previouisName))
                {
                    i = 0;
                    while (i <= playerList.Count)
                    {

                        if (playerList[i].Equals(previouisName))
                        {
                            if (i == playerList.Count - 1)
                            {
                                return playerList[0];
                            }
                            return playerList[i + 1];
                        }
                        else
                        {
                            i++;
                        }
                    }
                    return "Unknown";           
                }
            else
            {
                return FirstPlayer();
            }
        }
        public int PlayerAmount()
        {
            return playerList.Count();
        }
        public void RemovePlayer(Form form)
        {
            Remove_Player playername = new Remove_Player();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                if (playerList.Remove(playername.txtPlayerName.Text))
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
            Boolean result = false;
            


            Change_Player_Name playernames = new Change_Player_Name();
            if (playernames.ShowDialog(form) == DialogResult.OK)
            {
                i = 0;
                while (i <= playerList.Count)
                {
                    if (playerList[i].Equals(playernames.txtOldName.Text))
                    {
                        playerList.RemoveAt(i);
                        addPlayerToList(playernames.txtNewName.Text);
                        result = true;
                    }
                    else
                    {
                        i++;
                    }
                }
                if (result == true)
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
        public void AddPlayer(Form form)
        {
            Add_Player playername = new Add_Player();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                addPlayerToList(playername.txtPlayerName.Text);
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
            while (i < grid.RowCount - 1)
            {
                addPlayerToList(grid.Rows[i].Cells[0].Value.ToString());
                i++;
            }
        }
    }
}
