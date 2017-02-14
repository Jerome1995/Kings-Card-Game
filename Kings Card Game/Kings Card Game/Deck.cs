using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kings_Card_Game
{
    class Deck
    {
        private float numberOfDecks;
        private int cardsLeft;
        private Card card;
        private List<string> ExcludedCards;
        private int index = 0;
        private Random random = new Random();

        private List<String> DeckOfCards = new List<string>
        {
            "Ace Of Spades",
            "Two Of Spades",
            "Three Of Spades",
            "Four Of Spades",
            "Five Of Spades",
            "Six Of Spades",
            "Seven Of Spades",
            "Eight Of Spades",
            "Nine Of Spades",
            "Ten Of Spades",
            "Ace Of Hearts",
            "Two Of Hearts",
            "Three Of Hearts",
            "Four Of Hearts",
            "Five Of Hearts",
            "Six Of Hearts",
            "Seven Of Hearts",
            "Eight Of Hearts",
            "Nine Of Hearts",
            "Ten Of Hearts",
            "Ace Of Diamonds",
            "Two Of Diamonds",
            "Three Of Diamonds",
            "Four Of Diamonds",
            "Five Of Diamonds",
            "Six Of Diamonds",
            "Seven Of Diamonds",
            "Eight Of Diamonds",
            "Nine Of Diamonds",
            "Ten Of Diamonds",
            "Ace Of Clubs",
            "Two Of Clubs",
            "Three Of Clubs",
            "Four Of Clubs",
            "Five Of Clubs",
            "Six Of Clubs",
            "Seven Of Clubs",
            "Eight Of Clubs",
            "Nine Of Clubs",
            "Ten Of Clubs",
            "Jack Of Spades",
            "Jack Of Hearts",
            "Jack Of Diamonds",
            "Jack Of Clubs",
            "Queen Of Spades",
            "Queen Of Hearts",
            "Queen Of Diamonds",
            "Queen Of Clubs",
            "King Of Spades",
            "King Of Hearts",
            "King Of Diamonds",
            "King Of Clubs"
        };

        public Card getNextCard()
        {
            index = random.Next(DeckOfCards.Count);
            string randomCard = DeckOfCards[index];
            ExcludedCards.Add(DeckOfCards[index]);
            DeckOfCards.RemoveAt(index);

            switch (randomCard)
            {
                case "Ace Of Spades":
                {
                    card.setCardName("Ace Of Spades");
                    card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                    return card;
                }
                case "Two Of Spades":
                {
                    card.setCardName("Two Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Three Of Spades":
                {
                    card.setCardName("Three Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Four Of Spades":
                {
                    card.setCardName("Four Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Five Of Spades":
                {
                    card.setCardName("Five Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Six Of Spades":
                {
                    card.setCardName("Six Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Seven Of Spades":
                {
                    card.setCardName("Seven Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Eight Of Spades":
                {
                    card.setCardName("Eight Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Nine Of Spades":
                {
                    card.setCardName("Nine Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Ten Of Spades":
                {
                    card.setCardName("Ten Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Ace Of Clubs":
                {
                    card.setCardName("Ace Of Clubs");
                    card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                    return card;
                }
                case "Two Of Clubs":
                {
                    card.setCardName("Two Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Three Of Clubs":
                {
                    card.setCardName("Three Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Four Of Clubs":
                {
                    card.setCardName("Four Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Five Of Clubs":
                {
                    card.setCardName("Five Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Six Of Clubs":
                {
                    card.setCardName("Six Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Seven Of Clubs":
                {
                    card.setCardName("Seven Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Eight Of Clubs":
                {
                    card.setCardName("Eight Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Nine Of Clubs":
                {
                    card.setCardName("Nine Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Ten Of Clubs":
                {
                    card.setCardName("Ten Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Ace Of Hearts":
                {
                    card.setCardName("Ace Of Hearts");
                    card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                    return card;
                }
                case "Two Of Hearts":
                {
                    card.setCardName("Two Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Three Of Hearts":
                {
                    card.setCardName("Three Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Four Of Hearts":
                {
                    card.setCardName("Four Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Five Of Hearts":
                {
                    card.setCardName("Five Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Six Of Hearts":
                {
                    card.setCardName("Six Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Seven Of Hearts":
                {
                    card.setCardName("Seven Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Eight Of Hearts":
                {
                    card.setCardName("Eight Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Nine Of Hearts":
                {
                    card.setCardName("Nine Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Ten Of Hearts":
                {
                    card.setCardName("Ten Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Ace Of Diamonds":
                {
                    card.setCardName("Ace Of Diamonds");
                    card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                    return card;
                }
                case "Two Of Diamonds":
                {
                    card.setCardName("Two Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Three Of Diamonds":
                {
                    card.setCardName("Three Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Four Of Diamonds":
                {
                    card.setCardName("Four Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Five Of Diamonds":
                {
                    card.setCardName("Five Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Six Of Diamonds":
                {
                    card.setCardName("Six Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Seven Of Diamonds":
                {
                    card.setCardName("Seven Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Eight Of Diamonds":
                {
                    card.setCardName("Eight Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Nine Of Diamonds":
                {
                    card.setCardName("Nine Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Ten Of Diamonds":
                {
                    card.setCardName("Ten Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Jack Of Clubs":
                {
                    card.setCardName("Jack Of Clubs");
                    card.setCardRule("Waterfall: All players drink until player on their right stops drinking. Current player starts!");
                    return card;
                }
                case "Queen Of Clubs":
                {
                    card.setCardName("Queen Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "King Of Clubs":
                {
                    card.setCardName("King Of Clubs");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Jack Of Spades":
                {
                    card.setCardName("Jack Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Queen Of Spades":
                {
                    card.setCardName("Queen Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "King Of Spades":
                {
                    card.setCardName("King Of Spades");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Jack Of Hearts":
                {
                    card.setCardName("Jack Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Queen Of Hearts":
                {
                    card.setCardName("Queen Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "King Of Hearts":
                {
                    card.setCardName("King Of Hearts");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Jack Of Diamonds":
                {
                    card.setCardName("Jack Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "Queen Of Diamonds":
                {
                    card.setCardName("Queen Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }
                case "King Of Diamonds":
                {
                    card.setCardName("King Of Diamonds");
                    card.setCardRule("For You: Current player picks another player to drink for two seconds!");
                    return card;
                }

            }

        }

       

        /*setDecks(),addDeck(),removeDecks(),getCardsLeft(),setExcludedCard(),getNextCard(),restartGame(),getNumberOfDecks()*/


    }
}
 