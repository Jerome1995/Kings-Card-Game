using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Kings_Card_Game.Properties;

namespace Kings_Card_Game
{
    public abstract class Players : Deck
    {
        //Variables
        private string _playerName;
        private List<String> _playerList = new List<string>();
        private int _i;

        //Setters
        public void SetPlayerName(string name)
        {
            _playerName = name;
        }
        public void SetPlayerList(List<string> list)
        {
            _playerList = list;
        }
        //Getters 
        public string GetPlayerName()
        {
            return _playerName;
        }
        public List<string> GetPlayerList()
        {
            return _playerList;
        }

        //Methods
        public void AddPlayerToList(string name)
        {
            string dupName = name;
            _i = 0;
            int num = 1;
            while (_i <= _playerList.Count)
            {
                int count = _playerList.Count(j => j.Equals(dupName));
                if (count == 0)
                {
                    _playerList.Add(dupName);
                    _i = _playerList.Count + 1;
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
            _playerName = _playerList[0];
            return _playerName;
        }
        public string NextPlayer(string previouisName)
        {
            if (_playerList.Contains(previouisName))
                {
                    _i = 0;
                    while (_i <= _playerList.Count)
                    {
                        if (_playerList[_i].Equals(previouisName))
                        {
                            if (_i == _playerList.Count - 1)
                            {
                                return _playerList[0];
                            }
                            return _playerList[_i + 1];
                        }
                        _i++;
                    }
                    return "Unknown";           
                }
            return FirstPlayer();
        }
        public int PlayerAmount()
        {
            return _playerList.Count;
        }
        public void RemovePlayer(Form form)
        {
            RemovePlayer playername = new RemovePlayer();
            if (playername.ShowDialog(form) == DialogResult.OK)
            {
                if (playername.txtPlayerName.Text.Equals(""))
                {
                    MessageBox.Show(Resources.Valid_Name);
                }
                else
                {
                    if (_playerList.Remove(playername.txtPlayerName.Text))
                    {
                        MessageBox.Show(Resources.Player_Removed_Header, Resources.Player_Identifier + playername.txtPlayerName.Text + Resources.Player_Removed_Confirm);
                    }
                    else
                    {
                        MessageBox.Show(Resources.Error, Resources.Player_Identifier + playername.txtPlayerName.Text + Resources.Player_Removed_Fail);
                    }
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
            ChangePlayerName playernames = new ChangePlayerName();
            if (playernames.ShowDialog(form) == DialogResult.OK)
            {
                if (playernames.txtOldName.Text.Equals("") || playernames.txtNewName.Text.Equals(""))
                {
                    MessageBox.Show(Resources.Change_Player_Name_Message);
                }
                else
                {
                    _i = 0;
                    while (_i <= _playerList.Count)
                    {
                        if (_playerList[_i].Equals(playernames.txtOldName.Text))
                        {
                            _playerList.RemoveAt(_i);
                            AddPlayerToList(playernames.txtNewName.Text);
                            result = true;
                        }
                        else
                        {
                            _i++;
                        }
                    }
                    if (result)
                    {
                        MessageBox.Show(Resources.Change_Player_Name_Header, Resources.Player_Identifier + playernames.txtOldName.Text + Resources.Changed_Confirm + playernames.txtNewName.Text);
                    }
                    else
                    {
                        MessageBox.Show(Resources.Error, Resources.Player_Identifier + playernames.txtOldName.Text + Resources.Changed_Fail);
                    }
                }                
            }
            else
            {
                playernames.Dispose();
            }
        }
        public void AddPlayer(Form form)
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
                    AddPlayerToList(playername.txtPlayerName.Text);
                    MessageBox.Show(Resources.Player_Added, Resources.Player_Identifier + playername.txtPlayerName.Text + Resources.Was_Added);
                }
                
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
                AddPlayerToList(grid.Rows[i].Cells[0].Value.ToString());
                i++;
            }
        }
    }
}
