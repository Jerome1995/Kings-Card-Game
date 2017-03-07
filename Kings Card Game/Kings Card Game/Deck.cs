﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Kings_Card_Game
{
    public class Deck
    {
        private double numberOfDecks;
        private double orignalNumberOfDecks;
        private int cardsLeft=0;
        private int cardsUsed=0;
        private Card card;
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

        public Deck()
        {
            numberOfDecks = 0;
            cardsLeft = 0;
            card = new Card();
            ExcludedCards = new List<string>();
        }
        public Deck(double numDeck, int cardsLeft, Card card, List<String> exCards)
        {
            this.numberOfDecks = numDeck;
            this.cardsLeft = cardsLeft;
            this.card = card;
            ExcludedCards = exCards;
        }

        //Getters
        public List<string> getOrignalDeck()
        {
            return OrignalDeckOfCards;
        }
        public int getCardsLeft()
        {
            return this.cardsLeft;
        }
        public double getNumberOfDecks()
        {
            return numberOfDecks;
        }
        public List<string> getExcludedCards()
        {
            return ExcludedCards;
        }
        public List<string> remainingCards()
        {
            return DeckOfCards;
        }
        public int getCardsUsedCount()
        {
            return cardsUsed;
        }
        public List<string> getUsedCards()
        {
            return UsedCards;
        }

        
        //Functions
        public Card getNextCard()
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
                            card.setCardName("Ace Of Spades");
                            card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                            card.setImagePath("Ace Of Spades");
                            break;
                        }
                    case "Two Of Spades":
                        {
                            card.setCardName("Two Of Spades");
                            card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                            card.setImagePath("Two Of Spades");
                            break;
                        }
                    case "Three Of Spades":
                        {
                            card.setCardName("Three Of Spades");
                            card.setCardRule("For Me: Current player drinks for two seconds!");
                            card.setImagePath("Three Of Spades");
                            break;
                        }
                    case "Four Of Spades":
                        {
                            card.setCardName("Four Of Spades");
                            card.setCardRule("Girls: All girls drink for two seconds!");
                            card.setImagePath("Four Of Spades");    
                            break;
                        }
                    case "Five Of Spades":
                        {
                            card.setCardName("Five Of Spades");
                            card.setCardRule("Never Have I Ever: Current player names something they have not done and other players must drink if" +
                                "they have done it!");
                            card.setImagePath("Five Of Spades");    
                            break;
                        }
                    case "Six Of Spades":
                        {
                            card.setCardName("Six Of Spades");
                            card.setCardRule("Guys: Boys drink for two seconds!");
                            card.setImagePath("Six Of Spades");    
                            break;
                        }
                    case "Seven Of Spades":
                        {
                            card.setCardName("Seven Of Spades");
                            card.setCardRule("Heaven: All players reach for the sky, last player to raise his hand drinks for 2 seconds!");
                            card.setImagePath("Seven Of Spades");    
                            break;
                        }
                    case "Eight Of Spades":
                        {
                            card.setCardName("Eight Of Spades");
                            card.setCardRule("Pick A Mate: Current player picks another player to drink everytime they drink for the rest of the game!");
                            card.setImagePath("Eight Of Spades");    
                            break;
                        }
                    case "Nine Of Spades":
                        {
                            card.setCardName("Nine Of Spades");
                            card.setCardRule("Rhyme: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                                "to make mistake must drink for two seconds!");
                            card.setImagePath("Nine Of Spades");    
                            break;
                        }
                    case "Ten Of Spades":
                        {
                            card.setCardName("Ten Of Spades");
                            card.setCardRule("Category: Current player picks a category, in a clockwise rotation other players will name things related" +
                                "to this category. First player to make a mistake will drink for 2 seconds!");
                            card.setImagePath("Ten Of Spades");    
                            break;
                        }
                    case "Ace Of Clubs":
                        {
                            card.setCardName("Ace Of Clubs");
                            card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                            card.setImagePath("Ace Of Clubs");    
                            break;
                        }
                    case "Two Of Clubs":
                        {
                            card.setCardName("Two Of Clubs");
                            card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                            card.setImagePath("Two Of Clubs");    
                            break;
                        }
                    case "Three Of Clubs":
                        {
                            card.setCardName("Three Of Clubs");
                            card.setCardRule("For Me: Current player drinks for two seconds!");
                            card.setImagePath("Three Of Clubs");    
                            break;
                        }
                    case "Four Of Clubs":
                        {
                            card.setCardName("Four Of Clubs");
                            card.setCardRule("Girls: All girls drink for two seconds!");
                            card.setImagePath("Four Of Clubs");    
                            break;
                        }
                    case "Five Of Clubs":
                        {
                            card.setCardName("Five Of Clubs");
                            card.setCardRule("Never Have I Ever: Current player names something they have not done and other players must drink if" +
                            "they have done it!");
                            card.setImagePath("Five Of Clubs");    
                            break;
                        }
                    case "Six Of Clubs":
                        {
                            card.setCardName("Six Of Clubs");
                            card.setCardRule("Guys: Boys drink for two seconds!");
                            card.setImagePath("Six Of Clubs");    
                            break;
                        }
                    case "Seven Of Clubs":
                        {
                            card.setCardName("Seven Of Clubs");
                            card.setCardRule("Heaven: All players reach for the sky, last player to raise his hand drinks for 2 seconds!");
                            card.setImagePath("Six Of Clubs");    
                            break;
                        }
                    case "Eight Of Clubs":
                        {
                            card.setCardName("Eight Of Clubs");
                            card.setCardRule("Pick A Mate: Current player picks another player to drink everytime they drink for the rest of the game!");
                            card.setImagePath("Eight Of Clubs");    
                            break;
                        }
                    case "Nine Of Clubs":
                        {
                            card.setCardName("Nine Of Clubs");
                            card.setCardRule("Rhyme: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!");
                            card.setImagePath("Nine Of Clubs");    
                            break;
                        }
                    case "Ten Of Clubs":
                        {
                            card.setCardName("Ten Of Clubs");
                            card.setCardRule("Category: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!");
                            card.setImagePath("Ten Of Clubs");    
                            break;
                        }
                    case "Ace Of Hearts":
                        {
                            card.setCardName("Ace Of Hearts");
                            card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                            card.setImagePath("Ace Of Hearts");    
                            break;
                        }
                    case "Two Of Hearts":
                        {
                            card.setCardName("Two Of Hearts");
                            card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                            card.setImagePath("Two Of Hearts");    
                            break;
                        }
                    case "Three Of Hearts":
                        {
                            card.setCardName("Three Of Hearts");
                            card.setCardRule("For Me: Current player drinks for two seconds!");
                            card.setImagePath("Three Of Hearts");    
                            break;
                        }
                    case "Four Of Hearts":
                        {
                            card.setCardName("Four Of Hearts");
                            card.setCardRule("Girls: All girls drink for two seconds!");
                            card.setImagePath("Four Of Hearts");    
                            break;
                        }
                    case "Five Of Hearts":
                        {
                            card.setCardName("Five Of Hearts");
                            card.setCardRule("Never Have I Ever: Current player names something they have not done and other players must drink if" +
                            "they have done it!");
                            card.setImagePath("Five Of Hearts");    
                            break;
                        }
                    case "Six Of Hearts":
                        {
                            card.setCardName("Six Of Hearts");
                            card.setCardRule("Guys: Boys drink for two seconds!");
                            card.setImagePath("Six Of Hearts");   
                            break;
                        }
                    case "Seven Of Hearts":
                        {
                            card.setCardName("Seven Of Hearts");
                            card.setCardRule("Heaven: All players reach for the sky, last player to raise his hand drinks for 2 seconds!");
                            card.setImagePath("Seven Of Hearts");   
                            break;
                        }
                    case "Eight Of Hearts":
                        {
                            card.setCardName("Eight Of Hearts");
                            card.setCardRule("Pick A Mate: Current player picks another player to drink everytime they drink for the rest of the game!");
                            card.setImagePath("Eight Of Hearts");    
                            break;
                        }
                    case "Nine Of Hearts":
                        {
                            card.setCardName("Nine Of Hearts");
                            card.setCardRule("Rhyme: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!");
                            card.setImagePath("Nine Of Hearts");    
                            break;
                        }
                    case "Ten Of Hearts":
                        {
                            card.setCardName("Ten Of Hearts");
                            card.setCardRule("Category: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!");
                            card.setImagePath("Ten Of Hearts");    
                            break;
                        }
                    case "Ace Of Diamonds":
                        {
                            card.setCardName("Ace Of Diamonds");
                            card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                            card.setImagePath("Ace Of Diamonds");    
                            break;
                        }
                    case "Two Of Diamonds":
                        {
                            card.setCardName("Two Of Diamonds");
                            card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                            card.setImagePath("Two Of Diamonds");    
                            break;
                        }
                    case "Three Of Diamonds":
                        {
                            card.setCardName("Three Of Diamonds");
                            card.setCardRule("For Me: Current player drinks for two seconds!");
                            card.setImagePath("Three Of Diamonds");    
                            break;
                        }
                    case "Four Of Diamonds":
                        {
                            card.setCardName("Four Of Diamonds");
                            card.setCardRule("Girls: All girls drink for two seconds!");
                            card.setImagePath("Four Of Diamonds");    
                            break;
                        }
                    case "Five Of Diamonds":
                        {
                            card.setCardName("Five Of Diamonds");
                            card.setCardRule("Never Have I Ever: Current player names something they have not done and other players must drink if" +
                            "they have done it!");
                            card.setImagePath("Five Of Diamonds");    
                            break;
                        }
                    case "Six Of Diamonds":
                        {
                            card.setCardName("Six Of Diamonds");
                            card.setCardRule("Guys: Boys drink for two seconds!");
                            card.setImagePath("Six Of Diamonds");    
                            break;
                        }
                    case "Seven Of Diamonds":
                        {
                            card.setCardName("Seven Of Diamonds");
                            card.setCardRule("Heaven: All players reach for the sky, last player to raise his hand drinks for 2 seconds!");
                            card.setImagePath("Seven Of Diamonds");    
                            break;
                        }
                    case "Eight Of Diamonds":
                        {
                            card.setCardName("Eight Of Diamonds");
                            card.setCardRule("Pick A Mate: Current player picks another player to drink everytime they drink for the rest of the game!");
                            card.setImagePath("Eight Of Diamonds");    
                            break;
                        }
                    case "Nine Of Diamonds":
                        {
                            card.setCardName("Nine Of Diamonds");
                            card.setCardRule("Rhyme: Current player says a word, in clockwise rotation other players must name words that rhyme, first" +
                            "to make mistake must drink for two seconds!");
                            card.setImagePath("Nine Of Diamonds");   
                            break;
                        }
                    case "Ten Of Diamonds":
                        {
                            card.setCardName("Ten Of Diamonds");
                            card.setCardRule("Category: Current player picks a category, in a clockwise rotation other players will name things related" +
                            "to this category. First player to make a mistake will drink for 2 seconds!");
                            card.setImagePath("Ten Of Diamonds");   
                            break;
                        }
                    case "Jack Of Clubs":
                        {
                            card.setCardName("Jack Of Clubs");
                            card.setCardRule("Make A Rule: Current player is allowed to make a rule that all other players must follow!");
                            card.setImagePath("Jack Of Clubs");   
                            break;
                        }
                    case "Queen Of Clubs":
                        {
                            card.setCardName("Queen Of Clubs");
                            card.setCardRule("Question Master: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!");
                            card.setImagePath("Queen Of Clubs");    
                            break;
                        }
                    case "King Of Clubs":
                        {
                            card.setCardName("King Of Clubs");
                            card.setCardRule("Chalice: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!");
                            card.setImagePath("King Of Clubs");    
                            break;
                        }
                    case "Jack Of Spades":
                        {
                            card.setCardName("Jack Of Spades");
                            card.setCardRule("Make A Rule: Current player is allowed to make a rule that all other players must follow!");
                            card.setImagePath("Jack Of Spades");    
                            break;
                        }
                    case "Queen Of Spades":
                        {
                            card.setCardName("Queen Of Spades");
                            card.setCardRule("Question Master: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!");
                            card.setImagePath("Queen Of Spades");    
                            break;
                        }
                    case "King Of Spades":
                        {
                            card.setCardName("King Of Spades");
                            card.setCardRule("Chalice: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!");
                            card.setImagePath("King Of Spades");    
                            break;
                        }
                    case "Jack Of Hearts":
                        {
                            card.setCardName("Jack Of Hearts");
                            card.setCardRule("Make A Rule: Current player is allowed to make a rule that all other players must follow!");
                            card.setImagePath("Jack Of Hearts");    
                            break;
                        }
                    case "Queen Of Hearts":
                        {
                            card.setCardName("Queen Of Hearts");
                            card.setCardRule("Question Master: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!");
                            card.setImagePath("Queen Of Hearts");    
                            break;
                        }
                    case "King Of Hearts":
                        {
                            card.setCardName("King Of Hearts");
                            card.setCardRule("Chalice: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!");
                            card.setImagePath("King Of Hearts");    
                            break;
                        }
                    case "Jack Of Diamonds":
                        {
                            card.setCardName("Jack Of Diamonds");
                            card.setCardRule("Make A Rule: Current player is allowed to make a rule that all other players must follow!");
                            card.setImagePath("Jack Of Diamonds");   
                            break;
                        }
                    case "Queen Of Diamonds":
                        {
                            card.setCardName("Queen Of Diamonds");
                            card.setCardRule("Question Master: Current player becomes the question master, any player that answers his/her question" +
                                "must drink for 2 seconds!");
                            card.setImagePath("Queen Of Diamonds");    
                            break;
                        }
                    case "King Of Diamonds":
                        {
                            card.setCardName("King Of Diamonds");
                            card.setCardRule("Chalice: Current player puts a bit of his/her drink in an empty glass, player with last king must drink from the glass!");
                            card.setImagePath("King Of Diamonds");    
                            break;
                        }
                    default:
                        {
                            card = new Card();
                            break;
                        }
                }
            }
            return card;

        }
        public void joinDecks(double num)
        {
            int i = 0, j = 0;
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
        public void setDecks(double num)
        {
            joinDecks(num);
            numberOfDecks = num;
            orignalNumberOfDecks = num;
            cardsLeft = Convert.ToInt16(numberOfDecks*52);
        }
        public void addDeck(double num)
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
        }
        public Boolean removeDeck(double num)
        {
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
                return true;
            }
            return false;
        }       
        public void reduceCardsLeft(int num)
        {
            this.cardsLeft--;
            UsedCards.Add(DeckOfCards[num]);
            DeckOfCards.Remove(DeckOfCards[num]);
            updateCardsUsed(1);
        }
        public Boolean excludeCard(string card)
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
        public Boolean restartGame()
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
        public Boolean undoExclusion(string card)
        {
            int i = 0;
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
                return true;
            }
            else
            {
                return false;
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
        
    }
}
 