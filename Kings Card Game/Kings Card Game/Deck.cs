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
        //private Card card;
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

                switch (randomCard)
                {
                    case "Ace Of Spades":
                        {
                            setCardName("Ace Of Spades");
                            setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                            setImagePath("Ace Of Spades");
                            break;
                        }
                    case "Two Of Spades":
                        {
                            setCardName("Two Of Spades");
                            setCardRule("For You: Current player picks another player to drink for two seconds!");
                            setImagePath("Two Of Spades");
                            break;
                        }
                    case "Three Of Spades":
                        {
                            setCardName("Three Of Spades");
                            setCardRule("For Me: Current player drinks for two seconds!");
                            setImagePath("Three Of Spades");
                            break;
                        }
                    case "Four Of Spades":
                        {
                            setCardName("Four Of Spades");
                            setCardRule("Girls: All girls drink for two seconds!");
                            setImagePath("Four Of Spades");    
                            break;
                        }
                    case "Five Of Spades":
                        {
                            setCardName("Five Of Spades");
                            setCardRule("Never Have I Ever: Current player names something they have not done and other players must drink if" +
                                "they have done it!");
                            setImagePath("Five Of Spades");    
                            break;
                        }
                    case "Six Of Spades":
                        {
                            setCardName("Six Of Spades");
                            setCardRule("Guys: Boys drink for two seconds!");
                            setImagePath("Six Of Spades");    
                            break;
                        }
                    case "Seven Of Spades":
                        {
                            setCardName("Seven Of Spades");
                            setCardRule("Heaven: All players reach for the sky, last player to raise his hand drinks for 2 seconds!");
                            setImagePath("Seven Of Spades");    
                            break;
                        }
                    case "Eight Of Spades":
                        {
                            setCardName("Eight Of Spades");
                            setCardRule("Pick A Mate: Current player picks another player to drink everytime they drink for the rest of the game!");
                            setImagePath("Eight Of Spades");    
                            break;
                        }
                    case "Nine Of Spades":
                        {
                            setCardName("Nine Of Spades");
                            setCardRule("Rhyme: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                                "to make mistake must drink for two seconds!");
                            setImagePath("Nine Of Spades");    
                            break;
                        }
                    case "Ten Of Spades":
                        {
                            setCardName("Ten Of Spades");
                            setCardRule("Category: Current player picks a category, in a clockwise rotation other players will name things related" +
                                "to this category. First player to make a mistake will drink for 2 seconds!");
                            setImagePath("Ten Of Spades");    
                            break;
                        }
                    case "Ace Of Clubs":
                        {
                            setCardName("Ace Of Clubs");
                            setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                            setImagePath("Ace Of Clubs");    
                            break;
                        }
                    case "Two Of Clubs":
                        {
                            setCardName("Two Of Clubs");
                            setCardRule("For You: Current player picks another player to drink for two seconds!");
                            setImagePath("Two Of Clubs");    
                            break;
                        }
                    case "Three Of Clubs":
                        {
                            setCardName("Three Of Clubs");
                            setCardRule("For Me: Current player drinks for two seconds!");
                            setImagePath("Three Of Clubs");    
                            break;
                        }
                    case "Four Of Clubs":
                        {
                            setCardName("Four Of Clubs");
                            setCardRule("Girls: All girls drink for two seconds!");
                            setImagePath("Four Of Clubs");    
                            break;
                        }
                    case "Five Of Clubs":
                        {
                            setCardName("Five Of Clubs");
                            setCardRule("Never Have I Ever: Current player names something they have not done and other players must drink if" +
                            "they have done it!");
                            setImagePath("Five Of Clubs");    
                            break;
                        }
                    case "Six Of Clubs":
                        {
                            setCardName("Six Of Clubs");
                            setCardRule("Guys: Boys drink for two seconds!");
                            setImagePath("Six Of Clubs");    
                            break;
                        }
                    case "Seven Of Clubs":
                        {
                            setCardName("Seven Of Clubs");
                            setCardRule("Heaven: All players reach for the sky, last player to raise his hand drinks for 2 seconds!");
                            setImagePath("Six Of Clubs");    
                            break;
                        }
                    case "Eight Of Clubs":
                        {
                            setCardName("Eight Of Clubs");
                            setCardRule("Pick A Mate: Current player picks another player to drink everytime they drink for the rest of the game!");
                            setImagePath("Eight Of Clubs");    
                            break;
                        }
                    case "Nine Of Clubs":
                        {
                            setCardName("Nine Of Clubs");
                            setCardRule("Rhyme: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!");
                            setImagePath("Nine Of Clubs");    
                            break;
                        }
                    case "Ten Of Clubs":
                        {
                            setCardName("Ten Of Clubs");
                            setCardRule("Category: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!");
                            setImagePath("Ten Of Clubs");    
                            break;
                        }
                    case "Ace Of Hearts":
                        {
                            setCardName("Ace Of Hearts");
                            setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                            setImagePath("Ace Of Hearts");    
                            break;
                        }
                    case "Two Of Hearts":
                        {
                            setCardName("Two Of Hearts");
                            setCardRule("For You: Current player picks another player to drink for two seconds!");
                            setImagePath("Two Of Hearts");    
                            break;
                        }
                    case "Three Of Hearts":
                        {
                            setCardName("Three Of Hearts");
                            setCardRule("For Me: Current player drinks for two seconds!");
                            setImagePath("Three Of Hearts");    
                            break;
                        }
                    case "Four Of Hearts":
                        {
                            setCardName("Four Of Hearts");
                            setCardRule("Girls: All girls drink for two seconds!");
                            setImagePath("Four Of Hearts");    
                            break;
                        }
                    case "Five Of Hearts":
                        {
                            setCardName("Five Of Hearts");
                            setCardRule("Never Have I Ever: Current player names something they have not done and other players must drink if" +
                            "they have done it!");
                            setImagePath("Five Of Hearts");    
                            break;
                        }
                    case "Six Of Hearts":
                        {
                            setCardName("Six Of Hearts");
                            setCardRule("Guys: Boys drink for two seconds!");
                            setImagePath("Six Of Hearts");   
                            break;
                        }
                    case "Seven Of Hearts":
                        {
                            setCardName("Seven Of Hearts");
                            setCardRule("Heaven: All players reach for the sky, last player to raise his hand drinks for 2 seconds!");
                            setImagePath("Seven Of Hearts");   
                            break;
                        }
                    case "Eight Of Hearts":
                        {
                            setCardName("Eight Of Hearts");
                            setCardRule("Pick A Mate: Current player picks another player to drink everytime they drink for the rest of the game!");
                            setImagePath("Eight Of Hearts");    
                            break;
                        }
                    case "Nine Of Hearts":
                        {
                            setCardName("Nine Of Hearts");
                            setCardRule("Rhyme: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!");
                            setImagePath("Nine Of Hearts");    
                            break;
                        }
                    case "Ten Of Hearts":
                        {
                            setCardName("Ten Of Hearts");
                            setCardRule("Category: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!");
                            setImagePath("Ten Of Hearts");    
                            break;
                        }
                    case "Ace Of Diamonds":
                        {
                            setCardName("Ace Of Diamonds");
                            setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                            setImagePath("Ace Of Diamonds");    
                            break;
                        }
                    case "Two Of Diamonds":
                        {
                            setCardName("Two Of Diamonds");
                            setCardRule("For You: Current player picks another player to drink for two seconds!");
                            setImagePath("Two Of Diamonds");    
                            break;
                        }
                    case "Three Of Diamonds":
                        {
                            setCardName("Three Of Diamonds");
                            setCardRule("For Me: Current player drinks for two seconds!");
                            setImagePath("Three Of Diamonds");    
                            break;
                        }
                    case "Four Of Diamonds":
                        {
                            setCardName("Four Of Diamonds");
                            setCardRule("Girls: All girls drink for two seconds!");
                            setImagePath("Four Of Diamonds");    
                            break;
                        }
                    case "Five Of Diamonds":
                        {
                            setCardName("Five Of Diamonds");
                            setCardRule("Never Have I Ever: Current player names something they have not done and other players must drink if" +
                            "they have done it!");
                            setImagePath("Five Of Diamonds");    
                            break;
                        }
                    case "Six Of Diamonds":
                        {
                            setCardName("Six Of Diamonds");
                            setCardRule("Guys: Boys drink for two seconds!");
                            setImagePath("Six Of Diamonds");    
                            break;
                        }
                    case "Seven Of Diamonds":
                        {
                            setCardName("Seven Of Diamonds");
                            setCardRule("Heaven: All players reach for the sky, last player to raise his hand drinks for 2 seconds!");
                            setImagePath("Seven Of Diamonds");    
                            break;
                        }
                    case "Eight Of Diamonds":
                        {
                            setCardName("Eight Of Diamonds");
                            setCardRule("Pick A Mate: Current player picks another player to drink everytime they drink for the rest of the game!");
                            setImagePath("Eight Of Diamonds");    
                            break;
                        }
                    case "Nine Of Diamonds":
                        {
                            setCardName("Nine Of Diamonds");
                            setCardRule("Rhyme: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!");
                            setImagePath("Nine Of Diamonds");   
                            break;
                        }
                    case "Ten Of Diamonds":
                        {
                            setCardName("Ten Of Diamonds");
                            setCardRule("Category: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!");
                            setImagePath("Ten Of Diamonds");   
                            break;
                        }
                    case "Jack Of Clubs":
                        {
                            setCardName("Jack Of Clubs");
                            setCardRule("Make A Rule: Current player is allowed to make a rule that all other players must follow!");
                            setImagePath("Jack Of Clubs");   
                            break;
                        }
                    case "Queen Of Clubs":
                        {
                            setCardName("Queen Of Clubs");
                            setCardRule("Question Master: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!");
                            setImagePath("Queen Of Clubs");    
                            break;
                        }
                    case "King Of Clubs":
                        {
                            setCardName("King Of Clubs");
                            setCardRule("Chalice: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!");
                            setImagePath("King Of Clubs");    
                            break;
                        }
                    case "Jack Of Spades":
                        {
                            setCardName("Jack Of Spades");
                            setCardRule("Make A Rule: Current player is allowed to make a rule that all other players must follow!");
                            setImagePath("Jack Of Spades");    
                            break;
                        }
                    case "Queen Of Spades":
                        {
                            setCardName("Queen Of Spades");
                            setCardRule("Question Master: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!");
                            setImagePath("Queen Of Spades");    
                            break;
                        }
                    case "King Of Spades":
                        {
                            setCardName("King Of Spades");
                            setCardRule("Chalice: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!");
                            setImagePath("King Of Spades");    
                            break;
                        }
                    case "Jack Of Hearts":
                        {
                            setCardName("Jack Of Hearts");
                            setCardRule("Make A Rule: Current player is allowed to make a rule that all other players must follow!");
                            setImagePath("Jack Of Hearts");    
                            break;
                        }
                    case "Queen Of Hearts":
                        {
                            setCardName("Queen Of Hearts");
                            setCardRule("Question Master: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!");
                            setImagePath("Queen Of Hearts");    
                            break;
                        }
                    case "King Of Hearts":
                        {
                            setCardName("King Of Hearts");
                            setCardRule("Chalice: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!");
                            setImagePath("King Of Hearts");    
                            break;
                        }
                    case "Jack Of Diamonds":
                        {
                            setCardName("Jack Of Diamonds");
                            setCardRule("Make A Rule: Current player is allowed to make a rule that all other players must follow!");
                            setImagePath("Jack Of Diamonds");   
                            break;
                        }
                    case "Queen Of Diamonds":
                        {
                            setCardName("Queen Of Diamonds");
                            setCardRule("Question Master: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!");
                            setImagePath("Queen Of Diamonds");    
                            break;
                        }
                    case "King Of Diamonds":
                        {
                            setCardName("King Of Diamonds");
                            setCardRule("Chalice: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!");
                            setImagePath("King Of Diamonds");    
                            break;
                        }
                    default:
                        {
                            setCardName("");
                            setCardRule("");
                            setImagePath(""); 
                            break;
                        }
                }
            }

        }
        public void joinDecks(double num)
        {
            int i = 0, j = 0;
            cardsLeft = Convert.ToInt16(num * 52);
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
            this.cardsLeft = this.cardsLeft + Convert.ToInt16(num*52);
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
 