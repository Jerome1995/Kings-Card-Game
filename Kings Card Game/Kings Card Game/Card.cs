using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kings_Card_Game
{
    public abstract class Card
    {
        private string cardName;
        private string cardRule;
        private string cardImagePath;

        public void setCardName(string name)
        {
            this.cardName = name;
        }
        public void setCardRule(string rule)
        {
            this.cardRule = rule;
        }
        public void setImagePath(string path)
        {
            this.cardImagePath = path;
        }

        public string getCardName()
        {
            return cardName;
        }
        public string getCardRule()
        {
            return cardRule;
        }
        public string getImagePath()
        {
            return cardImagePath;
        }
    }
}
