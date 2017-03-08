using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kings_Card_Game;
using System.Collections.Generic;

namespace Kings_Card_Game_Test
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Setting_And_Getting_Name_Test()
        {
            //arange
            string expectedResult = "Ace Of Spades";
            Card card = new Card();

            //act
            card.setCardName("Ace Of Spades");

            //assert
            string actual = card.getCardName();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void Setting_And_Getting_Rule_Test()
        {
            //arange
            string expectedResult = "Drink For 2 Seconds";
            Card card = new Card();

            //act
            card.setCardRule("Drink For 2 Seconds");

            //assert
            string actual = card.getCardRule();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void Setting_And_Getting_ImagePath_Test()
        {
            //arange
            string expectedResult = "C:\\desktop\\image.png";
            Card card = new Card();

            //act
            card.setImagePath("C:\\desktop\\image.png");

            //assert
            string actual = card.getImagePath();
            Assert.AreEqual(expectedResult, actual);
        }
    }

    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void GetNextCard_Test()
        {
            //arange
            Boolean expectedResult = true;
            Deck deck = new Deck();
            Card card = new Card();
            List<string> list = new List<string>();
            list.AddRange(deck.getOrignalDeck());
            deck.setDecks(1);

            //act
            card = deck.getNextCard();

            //assert
            Boolean actual = list.Contains(card.getCardName());
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void JoinDecks_Test()
        {
            //arange
            int expectedResult = 104;
            Deck deck = new Deck();

            //act
            deck.joinDecks(2);

            //assert
            int actual = deck.remainingCards().Count;
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void SetDecks_Test()
        {
            //arange
            Boolean expectedResult = true;
            Deck deck = new Deck();
            
            //act
            deck.setDecks(2);

            //assert
            Boolean actual = false;
            if (deck.getNumberOfDecks() == 2 && deck.getCardsLeft() == 104)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void AddDeck_Test()
        {
            //arange
            Boolean expectedResult = true;
            Deck deck = new Deck();
            deck.setDecks(2);

            //act
            deck.addDeck(2);

            //assert
            Boolean actual = false;
            if (deck.getNumberOfDecks() == 4 && deck.getCardsLeft() == 208)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void RemoveDeck_Test()
        {
            //arange
            Boolean expectedResult = true;
            Deck deck = new Deck();
            deck.setDecks(3);

            //act
            Boolean result = deck.removeDeck(1);

            //assert
            Boolean actual = false;
            if (result == true && deck.getNumberOfDecks() == 2 && deck.getCardsLeft() == 104)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void ReduceCardsLeft_Test()
        {
            //arange
            Boolean expectedResult = true;
            Deck deck = new Deck();
            Card card = new Card();
            deck.setDecks(2);
            List<string> list = new List<string>();
            list = deck.remainingCards();
            card.setCardName(list[2]);

            //act
            deck.reduceCardsLeft(2);

            //assert
            Boolean actual = false;
            if (deck.getCardsLeft() == 103 && deck.getCardsUsedCount() == 1 
                && !deck.remainingCards()[2].Equals(card.getCardName())
                && deck.getUsedCards().Contains(card.getCardName()) == true)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void ExcludeCard_Test()
        {
            //arange
            Boolean expectedResult = true;
            Deck deck = new Deck();
            Card card = new Card();
            card.setCardName("Ace Of Spades");
            deck.setDecks(2);
            

            //act
            Boolean result = deck.excludeCard(card.getCardName());

            //assert
            Boolean actual = false;
            if (result == true && !deck.remainingCards().Contains(card.getCardName())
                && deck.getUsedCards().Contains(card.getCardName()) && deck.getCardsUsedCount() == 2
                && deck.getCardsLeft() == 102 && deck.getExcludedCards().Contains(card.getCardName()))
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void RestartGame_Test()
        {
            //arange
            Boolean expectedResult = true;
            Deck deck = new Deck();
            deck.setDecks(2);
            deck.addDeck(2);
            deck.excludeCard("Ace Of Spades");

            //act
            Boolean result = deck.restartGame();

            //assert
            Boolean actual = false;
            if (result == true && deck.getNumberOfDecks() == 2 && deck.remainingCards().Count == 104
                && deck.getExcludedCards().Count == 0 && deck.getUsedCards().Count == 0 && deck.getCardsLeft() == 104
                && deck.getCardsUsedCount() == 0)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void UndoExclusion_Test()
        {
            //arange
            Boolean expectedResult = true;
            string card = "Ace Of Spades";
            Deck deck = new Deck();
            deck.setDecks(2);
            deck.excludeCard(card);
            
            //act
            Boolean result = deck.undoExclusion(card);

            //assert
            Boolean actual = false;
            if (result == true && deck.remainingCards().Contains(card) && !deck.getUsedCards().Contains(card) 
                && !deck.getExcludedCards().Contains(card) && deck.getCardsLeft() == 104
                && deck.getCardsUsedCount() == 0)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void UpdateCardsUsed_Test()
        {
            //arange
            int expectedResult = 2;
            Deck deck = new Deck();
            

            //act
            deck.updateCardsUsed(2);

            //assert
            int actual = deck.getCardsUsedCount();
            Assert.AreEqual(expectedResult, actual);
        }
    }

    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void AddPlayer_Test()
        {
            //arange
            string expectedResult = "Jerome";
            Players player = new Players();


            //act
            player.addPlayer("Jerome");

            //assert
            string actual = player.getPlayer();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void NextPlayer_Test()
        {
            //arange
            string expectedResult = "Jerome";
            Players player = new Players();
            player.addPlayer("John");
            player.addPlayer("Jerome");

            //act
            string actual = player.nextPlayer("John");

            //assert
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void GetPlayerAmount_Test()
        {
            //arange
            int expectedResult = 2;
            Players player = new Players();
            player.addPlayer("Jerome");
            player.addPlayer("John");

            //act
            int actual = player.getPlayerAmount();

            //assert
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void RemovePlayer_Test()
        {
            //arange
            Boolean expectedResult = true;
            Players player = new Players();
            player.addPlayer("Jerome");
            player.addPlayer("John");
            player.addPlayer("Patrick");

            //act
            Boolean result = player.removePlayer("Patrick");

            //assert
            Boolean actual = false;
            if (result == true && player.getPlayerAmount() == 2)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void ChangePlayerName_Test()
        {
            //arange
            Boolean expectedResult = true;
            Players player = new Players();
            player.addPlayer("Jxrome");
            player.addPlayer("Patrick");

            //act
            Boolean result = player.changePlayerName("Jxrome", "Jerome");
            
            //assert
            Boolean actual = false;
            if (result == true && player.getPlayerAmount() == 2 && player.getPlayer().Equals("Jerome"))
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
