using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLibrary;


namespace FizzBuzzLibraryTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        private string checkGame;
        [TestMethod]
        public void CheckMultipleByThree()
        {
            checkGame = FizzBuzz.StartGame();
            Assert.IsTrue(checkGame.Contains("Fizz"));
        }
        [TestMethod]
        public void CheckMultipleByFive()
        {
            checkGame = FizzBuzz.StartGame();
            Assert.IsTrue(checkGame.Contains("Buzz"));
        }
        [TestMethod]
        public void CheckMultipleByThreeAndFive()
        {
            checkGame = FizzBuzz.StartGame();
            Assert.IsTrue(checkGame.Contains("FizzBuzz"));
        }

    }
}