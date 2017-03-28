using System;
using System.Collections.Generic;
using Kings_Card_Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;

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
            Game game = new Game();

            //act
            game.SetCardName("Ace Of Spades");

            //assert
            string actual = game.GetCardName();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void Setting_And_Getting_Rule_Test()
        {
            //arange
            string expectedResult = "Drink For 2 Seconds";
            Game game = new Game();

            //act
            game.SetCardRule("Drink For 2 Seconds");

            //assert
            string actual = game.GetCardRule();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void Setting_And_Getting_ImagePath_Test()
        {
            //arange
            string expectedResult = "C:\\desktop\\image.png";
            Game game = new Game();

            //act
            game.SetImagePath("C:\\desktop\\image.png");

            //assert
            string actual = game.GetImagePath();
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
            Game game = new Game();
            List<string> list = new List<string>();
            list.AddRange(game.GetOrignalDeck());
            game.SetDecks(1);

            //act
            game.NextCard();

            //assert
            Boolean actual = list.Contains(game.GetCardName());
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void JoinDecks_Test()
        {
            //arange
            int expectedResult = 104;
            Game game = new Game();

            //act
            game.JoinDecks(2);

            //assert
            int actual = game.CardsLeft();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void SetDecks_Test()
        {
            //arange
            Boolean expectedResult = true;
            Game game = new Game();
            
            //act
            game.SetDecks(2);

            //assert
            Boolean actual = false;
            if (game.NumberOfDecks() == 2 && game.CardsLeft() == 104)
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
            Game game = new Game();
            game.SetDecks(2);

            //act
            game.AddDeck(2);

            //assert
            Boolean actual = false;
            if (game.NumberOfDecks() == 4 && game.CardsLeft() == 208)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void RemoveDeck_Test()
        {
            //arange
            int expectedResult = 2;
            Game game = new Game();
            game.SetDecks(3);

            //act
            game.RemoveDeck(1);

            //assert
            double actual = game.NumberOfDecks();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void ReduceCardsLeft_Test()
        {
            //arange
            int expectedResult = 51;
            Game game = new Game();
            game.SetDecks(1);
            

            //act
            game.ReduceCardsLeft(1);

            //assert
            int actual = game.CardsLeft();
            
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void AddToExcludeCardList_Test()
        {
            //arange
            Boolean expectedResult = true;
            Game game = new Game();
            game.SetDecks(1);
            

            //act
            Boolean actual = game.AddToExcludeCardList("Ace Of Spades");

            //assert
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void RestartGame_Test()
        {
            //arange
            Boolean expectedResult = true;
            Game game = new Game();
            game.SetDecks(2);
            game.AddDeck(2);
            game.AddToExcludeCardList("Ace Of Spades");

            //act
            Boolean result = game.ResetGameDetails();

            //assert
            Boolean actual = false;
            if (result && game.NumberOfDecks() == 2 && game.GetCardsUsedCount() == 0
                && game.GetUsedCards().Count == 0 && game.CardsLeft() == 104)
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void UndoExclusionOfCard_Test()
        {
            //arange
            Boolean expectedResult = true;
            string card = "Ace Of Spades";
            Game game = new Game();
            game.SetDecks(2);
            game.AddToExcludeCardList(card);
            Kings form = new Kings(game);

            
            //act
            game.UndoExclusionOfCard(form);

            //assert
            Boolean actual = false;
            if (!game.GetUsedCards().Contains(card))
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
            Game game = new Game();
            

            //act
            game.UpdateCardsUsed(2);

            //assert
            int actual = game.GetCardsUsedCount();
            Assert.AreEqual(expectedResult, actual);
        }
    }

    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void AddPlayerToList_Test()
        {
            //arange
            string expectedResult = "Jerome_3";
            Game game = new Game();


            //act
            game.AddPlayerToList("Jerome");
            game.AddPlayerToList("Jerome");
            game.AddPlayerToList("Jerome");

            //assert
            string actual = game.NextPlayer("Jerome_2");
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void NextPlayer_Test()
        {
            //arange
            string expectedResult = "Jerome";
            Game game = new Game();
            game.AddPlayerToList("John");
            game.AddPlayerToList("Jerome");

            //act
            string actual = game.NextPlayer("John");

            //assert
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void GetPlayerAmount_Test()
        {
            //arange
            int expectedResult = 2;
            Game game = new Game();
            game.AddPlayerToList("Jerome");
            game.AddPlayerToList("John");

            //act
            int actual = game.PlayerAmount();

            //assert
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
