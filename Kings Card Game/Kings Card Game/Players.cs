using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public void addPlayer(string name)
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
        public string getPlayer()
        {
            playerName = playerList[0];
            return playerName;
        }
        public string nextPlayer(string previouisName)
        {
            i = 0;
            while (i <= playerList.Count)
            {
                if (playerList[i].Equals(previouisName))
                {
                    if (i == playerList.Count-1)
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
        public int getPlayerAmount()
        {
            return playerList.Count();
        }
        public Boolean removePlayer(string name)
        {
            return playerList.Remove(name);
        }
        public Boolean changePlayerName(string oldName,string newName)
        {
            i = 0;
            while (i <= playerList.Count)
            {
                if (playerList[i].Equals(oldName))
                {
                    playerList.RemoveAt(i);
                    playerList.Insert(i, newName);
                    return true;
                }
                else
                {
                    i++;
                }
            }
            return false;
        }        
    }
}
