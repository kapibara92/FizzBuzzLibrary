using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FizzBuzzLibrary;


namespace FizzBuzzLibraryTest
{
    [TestClass]
    public class FizzBuzzTest
    {
        [TestMethod]
        public void CheckMultipleByThree()
        {
            int[] numberMulitipleByThree = new int[3];
            numberMulitipleByThree[0]=3;
            numberMulitipleByThree[1]=6;
            numberMulitipleByThree[2]=18;
            bool isWrong = false;
            for(int i=0; i < numberMulitipleByThree.Length; i++)
            {
                string checkGame = FizzBuzz.GetFizzOrBuzzOrNumber(numberMulitipleByThree[i]);
                if( checkGame != "Fizz")
                {
                    isWrong = true;
                    goto endCheck;
                }
            }
            endCheck:
            Assert.IsTrue(isWrong==false);
        }
        [TestMethod]
        public void CheckMultipleByFive()
        {
            int[] numberMulitipleByFive = new int[3];
            numberMulitipleByFive[0] = 5;
            numberMulitipleByFive[1] = 20;
            numberMulitipleByFive[2] = 25;
            bool isWrong = false;
            for (int i = 0; i < numberMulitipleByFive.Length; i++)
            {
                string checkGame = FizzBuzz.GetFizzOrBuzzOrNumber(numberMulitipleByFive[i]);
                if (checkGame != "Buzz")
                {
                    isWrong = true;
                    goto endCheck;
                }
            }
            endCheck:
            Assert.IsTrue(isWrong == false);
        }
        [TestMethod]
        public void CheckMultipleByThreeAndFive()
        {
            int[] numberMulitipleByFiveOrThree = new int[3];
            numberMulitipleByFiveOrThree[0] = 15;
            numberMulitipleByFiveOrThree[1] = 30;
            numberMulitipleByFiveOrThree[2] = 45;
            bool isWrong = false;
            for (int i = 0; i < numberMulitipleByFiveOrThree.Length; i++)
            {
                string checkGame = FizzBuzz.GetFizzOrBuzzOrNumber(numberMulitipleByFiveOrThree[i]);
                if (checkGame != "FizzBuzz")
                {
                    isWrong = true;
                    goto endCheck;
                }
            }
            endCheck:
            Assert.IsTrue(isWrong == false);
        }
        [TestMethod]
        public void CheckRangeOfNumber()
        {
            int invalidNumber=0;
            try
            {
                string checkGame = FizzBuzz.GetFizzOrBuzzOrNumber(invalidNumber);
                Assert.Fail("method should work only for numbers greater than 0");
            }
            catch(ArgumentOutOfRangeException e)
            {
                Assert.IsNotNull(e.Message);
            }
            catch(Exception e)
            {
                Assert.Fail("unhandled exception: "+ e.Message);
            }
        }
        [TestMethod]
        public void CheckNotMultipleByThreeOrFive()
        {
            string message = "";
            int[] numberMulitipleByFiveOrThree = new int[3];
            numberMulitipleByFiveOrThree[0] = 7;
            numberMulitipleByFiveOrThree[1] = 26;
            numberMulitipleByFiveOrThree[2] = 74;
            bool isWrong = false;
            for (int i = 0; i < numberMulitipleByFiveOrThree.Length; i++)
            {
                string checkGame = FizzBuzz.GetFizzOrBuzzOrNumber(numberMulitipleByFiveOrThree[i]);
                if (checkGame != numberMulitipleByFiveOrThree[i].ToString())
                {
                    isWrong = true;
                    message = checkGame;
                    goto endCheck;
                }
            }
            endCheck:
            Assert.IsTrue(isWrong == false, message);
        }

    }
}