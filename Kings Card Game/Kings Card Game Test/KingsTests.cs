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
            Game game = new Game();

            //act
            game.setCardName("Ace Of Spades");

            //assert
            string actual = game.getCardName();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void Setting_And_Getting_Rule_Test()
        {
            //arange
            string expectedResult = "Drink For 2 Seconds";
            Game game = new Game();

            //act
            game.setCardRule("Drink For 2 Seconds");

            //assert
            string actual = game.getCardRule();
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void Setting_And_Getting_ImagePath_Test()
        {
            //arange
            string expectedResult = "C:\\desktop\\image.png";
            Game game = new Game();

            //act
            game.setImagePath("C:\\desktop\\image.png");

            //assert
            string actual = game.getImagePath();
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
            list.AddRange(game.getOrignalDeck());
            game.SetDecks(1);

            //act
            game.NextCard();

            //assert
            Boolean actual = list.Contains(game.getCardName());
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void JoinDecks_Test()
        {
            //arange
            int expectedResult = 104;
            Game game = new Game();

            //act
            game.joinDecks(2);

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
            game.reduceCardsLeft(1);

            //assert
            int actual = game.CardsLeft();
            
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void ExcludeCard_Test()
        {
            //arange
            Boolean expectedResult = true;
            Game game = new Game();
            game.SetDecks(1);
            

            //act
            game.ExcludeCard(form);

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
            if (result == true && game.NumberOfDecks() == 2 && game.ShowRemainingCards().Count == 104
                && game.ShowExcludedCards().Count == 0 && game.getUsedCards().Count == 0 && game.CardsLeft() == 104
                && game.getCardsUsedCount() == 0)
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
            Game game = new Game();
            game.SetDecks(2);
            game.AddToExcludeCardList(card);
            
            //act
            Boolean result = game.undoExclusion(card);

            //assert
            Boolean actual = false;
            if (result == true && game.ShowRemainingCards().Contains(card) && !game.getUsedCards().Contains(card) 
                && !game.ShowExcludedCards().Contains(card) && game.CardsLeft() == 104
                && game.getCardsUsedCount() == 0)
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
            game.updateCardsUsed(2);

            //assert
            int actual = game.getCardsUsedCount();
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
            string expectedResult = "Jerome_3";
            Game game = new Game();


            //act
            game.addPlayerToList("Jerome");
            game.addPlayerToList("Jerome");
            game.addPlayerToList("Jerome");

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
            game.addPlayerToList("John");
            game.addPlayerToList("Jerome");

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
            game.addPlayerToList("Jerome");
            game.addPlayerToList("John");

            //act
            int actual = game.PlayerAmount();

            //assert
            Assert.AreEqual(expectedResult, actual);
        }
        [TestMethod]
        public void RemovePlayer_Test()
        {
            //arange
            Boolean expectedResult = true;
            Game game = new Game();
            game.addPlayerToList("Jerome");
            game.addPlayerToList("John");
            game.addPlayerToList("Patrick");

            //act
            Boolean result = game.RemovePlayer(this);

            //assert
            Boolean actual = false;
            if (result == true && game.PlayerAmount() == 2)
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
            Game game = new Game();
            game.addPlayerToList("Jxrome");
            game.addPlayerToList("Patrick");

            //act
            Boolean result = game.changePlayerName("Jxrome", "Jerome");
            
            //assert
            Boolean actual = false;
            if (result == true && game.PlayerAmount() == 2 && game.FirstPlayer().Equals("Jerome"))
            {
                actual = true;
            }
            Assert.AreEqual(expectedResult, actual);
        }
    }
}
