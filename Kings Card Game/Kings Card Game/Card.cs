using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kings_Card_Game
{
    public class Card
    {
        private string cardName;
        private string cardRule;

        public Card()
        {
            cardName = "";
            cardRule = "";
        }

        public Card(string name, string rule)
        {
            this.cardName = name;
            this.cardRule = rule;
        }

        public void setCardName(string name)
        {
            this.cardName = name;
        }

        public void setCardRule(string rule)
        {
            this.cardRule = rule;
        }

        public string getCardName()
        {
            return cardName;
        }

        public string getCardRule()
        {
            return cardRule;
        }
    }
}
