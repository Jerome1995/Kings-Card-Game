using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kings_Card_Game
{
    public abstract class Deck : Card
    {
        //Variables
        private double numberOfDecks;
        private double orignalNumberOfDecks;
        private int cardsLeft=0;
        private int cardsUsed=0;
        private List<string> ExcludedCards = new List<string>();
        private List<string> DeckOfCards = new List<string>();
        private List<string> UsedCards = new List<string>();
        private int index = 0;
        private Random random = new Random();
        private List<String> OrignalDeckOfCards = new List<string>
        {
            "Ace Of Spades","Two Of Spades","Three Of Spades","Four Of Spades","Five Of Spades","Six Of Spades","Seven Of Spades",
            "Eight Of Spades","Nine Of Spades","Ten Of Spades","Ace Of Hearts","Two Of Hearts","Three Of Hearts","Four Of Hearts",
            "Five Of Hearts","Six Of Hearts","Seven Of Hearts","Eight Of Hearts","Nine Of Hearts","Ten Of Hearts","Ace Of Diamonds",
            "Two Of Diamonds","Three Of Diamonds","Four Of Diamonds","Five Of Diamonds","Six Of Diamonds","Seven Of Diamonds",
            "Eight Of Diamonds","Nine Of Diamonds","Ten Of Diamonds","Ace Of Clubs","Two Of Clubs","Three Of Clubs","Four Of Clubs",
            "Five Of Clubs","Six Of Clubs","Seven Of Clubs","Eight Of Clubs","Nine Of Clubs","Ten Of Clubs","Jack Of Spades",
            "Jack Of Hearts","Jack Of Diamonds","Jack Of Clubs","Queen Of Spades","Queen Of Hearts","Queen Of Diamonds",
            "Queen Of Clubs","King Of Spades","King Of Hearts","King Of Diamonds","King Of Clubs"
        };
        Dictionary<string, string> CardRule = new Dictionary<string, string>()
        {
            {"Ace Of Spades","WATERFALL: All players drink until player on their right stops drinking. Current player starts!"},
            {"Two Of Spades","FOR YOU: Current player picks another player to drink for two seconds!"},
            {"Three Of Spades","FOR ME: Current player drinks for two seconds!"},
            {"Four Of Spades","GIRLS: All girls drink for two seconds!"},
            {"Five Of Spades","NEVER HAVE I EVER: Current player names something they have not done and other players must drink if"},
            {"Six Of Spades","GUYS: Boys drink for two seconds!"},
            {"Seven Of Spades","HEAVAN: All players reach for the sky, last player to raise his hand drinks for 2 seconds!"},
            {"Eight Of Spades","PICK A MATE: Current player picks another player to drink everytime they drink for the rest of the game!"},
            {"Nine Of Spades","RHYME: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                                "to make mistake must drink for two seconds!"},
            {"Ten Of Spades","CATEGORY: Current player picks a category, in a clockwise rotation other players will name things related" +
                                "to this category. First player to make a mistake will drink for 2 seconds!"},
            {"Ace Of Clubs","WATERFALL: All players drink until player on their right stops drinking. Current player starts!"},
            {"Two Of Clubs","FOR YOU: Current player picks another player to drink for two seconds!"},
            {"Three Of Clubs","FOR ME: Current player drinks for two seconds!"},
            {"Four Of Clubs","GIRLS: All girls drink for two seconds!"},
            {"Five Of Clubs","NEVER HAVE I EVER: Current player names something they have not done and other players must drink if" +
                            "they have done it!"},
            {"Six Of Clubs","GUYS: Boys drink for two seconds!"},
            {"Seven Of Clubs","HEAVAN: All players reach for the sky, last player to raise his hand drinks for 2 seconds!"},
            {"Eight Of Clubs","PICK A MATE: Current player picks another player to drink everytime they drink for the rest of the game!"},
            {"Nine Of Clubs","RHYME: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!"},
            {"Ten Of Clubs","CATEGORY: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!"},
            {"Ace Of Hearts","WATERFALL: All players drink until player on their right stops drinking. Current player starts!"},
            {"Two Of Hearts","FOR YOU: Current player picks another player to drink for two seconds!"},
            {"Three Of Hearts","FOR ME: Current player drinks for two seconds!"},
            {"Four Of Hearts","GIRLS: All girls drink for two seconds!"},
            {"Five Of Hearts","NEVER HAVE I EVER: Current player names something they have not done and other players must drink if" +
                            "they have done it!"},
            {"Six Of Hearts","GUYS: Boys drink for two seconds!"},
            {"Seven Of Hearts","HEAVAN: All players reach for the sky, last player to raise his hand drinks for 2 seconds!"},
            {"Eight Of Hearts","PICK A MATE: Current player picks another player to drink everytime they drink for the rest of the game!"},
            {"Nine Of Hearts","RHYME: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!"},
            {"Ten Of Hearts","CATEGORY: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!"},
            {"Ace Of Diamonds","WATERFALL: All players drink until player on their right stops drinking. Current player starts!"},
            {"Two Of Diamonds","FOR YOU: Current player picks another player to drink for two seconds!"},
            {"Three Of Diamonds","FOR ME: Current player drinks for two seconds!"},
            {"Four Of Diamonds","GIRLS: All girls drink for two seconds!"},
            {"Five Of Diamonds","NEVER HAVE I EVER: Current player names something they have not done and other players must drink if" +
                            "they have done it!"},
            {"Six Of Diamonds","GUYS: Boys drink for two seconds!"},
            {"Seven Of Diamonds","HEAVAN: All players reach for the sky, last player to raise his hand drinks for 2 seconds!"},
            {"Eight Of Diamonds","PICK A MATE: Current player picks another player to drink everytime they drink for the rest of the game!"},
            {"Nine Of Diamonds","RHYME: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!"},
            {"Ten Of Diamonds","CATEGORY: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!"},
            {"Jack Of Clubs","MAKE A RULE: Current player is allowed to make a rule that all other players must follow!"},
            {"Queen Of Clubs","QUESTION MASTER: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!"},
            {"King Of Clubs","CHALICE: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!"},
            {"Jack Of Spades","MAKE A RULE: Current player is allowed to make a rule that all other players must follow!"},
            {"Queen Of Spades","QUESTION MASTER: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!"},
            {"King Of Spades","CHALICE: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!"},
            {"Jack Of Hearts","MAKE A RULE: Current player is allowed to make a rule that all other players must follow!"},
            {"Queen Of Hearts","QUESTION MASTER: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!"},
            {"King Of Hearts","CHALICE: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!"},
            {"Jack Of Diamonds","MAKE A RULE: Current player is allowed to make a rule that all other players must follow!"},
            {"Queen Of Diamonds","QUESTION MASTER: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!"},
            {"King Of Diamonds","CHALICE: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!"}                                    
        };


        //Getters
        public List<string> getOrignalDeck()
        {
            return OrignalDeckOfCards;
        }
        public int CardsLeft()
        {
            return this.cardsLeft;
        }
        public double NumberOfDecks()
        {
            return numberOfDecks;
        }
        public ComboBox ShowExcludedCards(ComboBox combo)
        {
            int i = 0;
            foreach (string x in ExcludedCards)
            {
                combo.Items.Insert(i, x);
                i++;
            }
            return combo;
        }
        public ComboBox ShowRemainingCards(ComboBox combo)
        {
            int i = 0;
            foreach (string x in DeckOfCards)
            {
                combo.Items.Insert(i, x);
                i++;
            }
            return combo;
        }
        public int getCardsUsedCount()
        {
            return cardsUsed;
        }
        public List<string> getUsedCards()
        {
            return UsedCards;
        }

        //Setters
        public void setNumberOfDecks(double num)
        {
            this.numberOfDecks = num;
        }
        public void setCardsLeft(int num)
        {
            this.cardsLeft = num;
        }
        public void setExcludedCards(List<string> list)
        {
            this.ExcludedCards = list;
        }
        
        //Methods
        public void NextCard()
        {
            index = random.Next(DeckOfCards.Count);
            if (cardsLeft != 0)
            {
                string randomCard = DeckOfCards[index];
                reduceCardsLeft(index);
                setCardName(randomCard);
                setCardRule(CardRule[randomCard]);
                setImagePath(randomCard);               
            }

        }
        public void joinDecks(double num)
        {
            int i = 0, j = 0;
            cardsLeft += Convert.ToInt16(num * 52);
            while (i < num)
            {
                DeckOfCards.AddRange(OrignalDeckOfCards);
                i++;
            }
            if ((num - i) == 0.5)
            {
                while (j <= 25)
                {
                    DeckOfCards.InsertRange(j, OrignalDeckOfCards);
                    j++;
                }
            }
        }
        public void SetDecks(double num)
        {
            joinDecks(num);
            numberOfDecks = num;
            orignalNumberOfDecks = num;
            
        }
        public void AddDeck(double num)
        {
            joinDecks(num);
            this.numberOfDecks = num + this.numberOfDecks;
            int i = 0;
            while (i < ExcludedCards.Count)
            {
                if (DeckOfCards.Contains(ExcludedCards[i]))
                {
                    DeckOfCards.Remove(ExcludedCards[i]);
                    cardsLeft--;
                }
                if (DeckOfCards.Contains(ExcludedCards[i]) == false)
                {
                    i++;
                }
            }
            MessageBox.Show("Deck Added", num + " Decks have been added.");
        }
        public void RemoveDeck(double num)
        {
            Boolean result = false;
            if (this.numberOfDecks > num)
            {
                this.numberOfDecks = this.numberOfDecks - num;
                this.cardsLeft = this.cardsLeft - Convert.ToInt16(num*52);
                int i = 0, j = 0;
                while (i < num)
                {
                    while (j <= 51)
                    {
                        DeckOfCards.Remove(OrignalDeckOfCards[j]);
                        j++;
                    }
                    i++;
                }
                if ((num - i) == 0.5)
                {
                    j = 0;
                    while (j <= 25)
                    {
                        DeckOfCards.Remove(OrignalDeckOfCards[j]);
                        j++;
                    }
                }
                result = true;
            }
            if (result)
            {
                MessageBox.Show("Deck Removed", num + " Decks have been removed.");
            }
            else
            {
                MessageBox.Show("Error!", " Decks could not be removed as the number of decks to be removed was greater than the number of decks available.");
            }
        }       
        public void reduceCardsLeft(int num)
        {
            this.cardsLeft--;
            UsedCards.Add(DeckOfCards[num]);
            DeckOfCards.Remove(DeckOfCards[num]);
            updateCardsUsed(1);
        }
        public Boolean AddToExcludeCardList(string card)
        {
            Boolean fini = false;
            while (fini == false)
            {
                if (DeckOfCards.Contains(card))
                {
                    DeckOfCards.Remove(card);
                    UsedCards.Add(card);
                    this.cardsLeft--;
                    updateCardsUsed(1);
                }
                if (DeckOfCards.Contains(card) == false)
                {
                    fini = true;
                    ExcludedCards.Add(card);
                }
            }
            return fini;
        }
        public Boolean ResetGameDetails()
        {
            this.cardsUsed = 0;
            this.cardsLeft = Convert.ToInt16(orignalNumberOfDecks * 52);
            this.numberOfDecks = orignalNumberOfDecks;
            DeckOfCards.Clear();
            UsedCards.Clear();
            ExcludedCards.Clear();
            joinDecks(orignalNumberOfDecks);
            return true;
        }    
        public void UndoExclusionOfCard(Form form)
        {
            Boolean result = false;
            int i = 0;
            Undo_Card_Exclusion uCard = new Undo_Card_Exclusion();
            uCard.comboCard = ShowExcludedCards(uCard.comboCard);
            if (uCard.ShowDialog(form) == DialogResult.OK)
            {
                string card = uCard.comboCard.SelectedItem.ToString();
                if (!uCard.comboCard.SelectedItem.Equals(null))
                {
                    while (i <= UsedCards.Count())
                    {
                        if (UsedCards.Contains(card))
                        {
                            DeckOfCards.Add(card);
                            UsedCards.Remove(card);
                            cardsLeft++;
                            updateCardsUsed(-1);
                        }
                        i++;
                    }
                    if (!UsedCards.Contains(card))
                    {
                        ExcludedCards.Remove(card);
                        result = true;
                    }
                    if (result)
                    {
                        MessageBox.Show("Exclusion Undone",
                            "The card " + card + " has been added back to the deck");
                    }
                    else
                    {
                        MessageBox.Show("Error!",
                            "The card " + card + " counld not be added back to the deck");
                    }
                }
            }
            else
            {
                uCard.Dispose();
            }
        }
        public void updateCardsUsed(int num)
        {
            cardsUsed = cardsUsed + num;
            if (cardsUsed == 26)
            {
                numberOfDecks = numberOfDecks - 0.5;
                cardsUsed = 0;
            }
        }

        public void ExcludeCard(Form form)
        {
            Exclude_Cards eCard = new Exclude_Cards();
            eCard.comboCard = ShowRemainingCards(eCard.comboCard);
            if (eCard.ShowDialog(form) == DialogResult.OK)
            {
                if (!eCard.comboCard.SelectedItem.Equals(null))
                {
                    Boolean result = AddToExcludeCardList(eCard.comboCard.SelectedItem.ToString());
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
                result = AddToExcludeCardList(grid.Rows[i].Cells[0].Value.ToString());
                i++;
            }
        }
    }
}
 