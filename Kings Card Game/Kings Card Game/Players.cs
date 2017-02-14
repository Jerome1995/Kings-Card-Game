using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kings_Card_Game
{
    public class Players
    {
        private string playerName;
        private List<String> playerList;
        private int i = 0;

        public Players()
        {
            playerName = "";
            playerList = new List<string>();
        }

        public Players(string name)
        {
            this.playerName = name;
            playerList.Add(playerName);
        }

        public void addPlayer(string name)
        {
            this.playerName = name;
            playerList.Add(playerName);
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
                    if (i == playerList.Count)
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

        public Boolean nameExists(string name)
        {
            Predicate<String> checkName = (String p) => { return p == name; };
            return playerList.Exists(checkName);
        }
    }
}
