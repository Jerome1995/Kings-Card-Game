using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Kings_Card_Game;

namespace Kings_Card_Game_Test
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Setting_And_Getting_Name()
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
        public void Setting_And_Getting_Rule()
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
        public void Setting_And_Getting_ImagePath()
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
        public void TestMethod1()
        {

        }
    }

    [TestClass]
    public class GameTests
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }

    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    }
}
