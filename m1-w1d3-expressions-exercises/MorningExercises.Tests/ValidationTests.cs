using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MorningExercises;

namespace MorningExercises.Tests
{
    [TestClass]
    public class ValidationTests
    {
        private MorningExercise exercises = new MorningExercise();

        [TestMethod]
        public void Test_1_ReturnNotOne()
        {
            Assert.AreNotEqual(1, exercises.ReturnNotOne(), "Value returned shouldn't be one");
        }


        [TestMethod]
        public void Test_2_ReturnNotHalf()
        {
            Assert.AreNotEqual(0.5, exercises.ReturnNotHalf(), 0.001, "Value returned shouldn't be 0.5");
        }

        [TestMethod]
        public void Test_3_ReturnName()
        {
            Assert.IsNotNull(exercises.ReturnName(), "Value returned should be your name");
        }

        [TestMethod]
        public void Test_4_ReturnDoubleOfTwo()
        {
            Assert.IsTrue(exercises.GetType() == typeof(double), "Value returned should be a double");
            Assert.AreEqual(2.0, exercises.ReturnDoubleOfTwo(), 0, "Value returned should still equal two");
        }

        [TestMethod]
        public void Test_5_ReturnNameOfLanguage()
        {
            Assert.AreEqual("C#", exercises.ReturnNameOfLanguage(), "Value should equal the name of the programming language you're learning");
        }

        [TestMethod]
        public void Test_6_ReturnTrueFromIf()
        {
            Assert.IsTrue(exercises.ReturnTrueFromIf(), "If statement should return true");
        }

        [TestMethod]
        public void Test_7_ReturnTrueWhenOneEqualsOne()
        {
            Assert.IsTrue(exercises.ReturnTrueWhenOneEqualsOne(), "If statement should return true");
        }

        [TestMethod]
        public void Test_8_ReturnTrueWhenGreaterThanFive()
        {
            Assert.IsTrue(exercises.ReturnTrueWhenGreaterThanFive(6), "We should return true when parameter is greater than five");
            Assert.IsFalse(exercises.ReturnTrueWhenGreaterThanFive(5), "We should return false when parameter is five");
            Assert.IsFalse(exercises.ReturnTrueWhenGreaterThanFive(4), "We should return false when parameter is smaller than five");
        }

        [TestMethod]
        public void Test_9_ReturnTrueWhenGreaterThanFiveInOneLine()
        {
            Assert.IsTrue(exercises.ReturnTrueWhenGreaterThanFiveInOneLine(6), "We should return true when parameter is greater than five");
            Assert.IsFalse(exercises.ReturnTrueWhenGreaterThanFiveInOneLine(5), "We should return false when parameter is five");
            Assert.IsFalse(exercises.ReturnTrueWhenGreaterThanFiveInOneLine(4), "We should return false when parameter is smaller than five");
        }

        [TestMethod]
        public void Test_10_ReturnNumberAfterAddThreeAndAddFive()
        {
            Assert.AreEqual(9, exercises.ReturnNumberAfterAddThreeAndAddFive(1, true, true), "We should add three and five when both are true");
            Assert.AreEqual(4, exercises.ReturnNumberAfterAddThreeAndAddFive(1, true, false), "We should add three when passed true false");
            Assert.AreEqual(6, exercises.ReturnNumberAfterAddThreeAndAddFive(1, false, true), "We should add five when passed false true");
            Assert.AreEqual(1, exercises.ReturnNumberAfterAddThreeAndAddFive(1, false, false), "We should return the original number when both are false");
        }

        [TestMethod]
        public void Test_11_ReturnFiveUsingPlusPlus()
        {
            Assert.AreEqual(5, exercises.ReturnFiveUsingPlusPlus());
        }

        [TestMethod]
        public void Test_12_ReturnFourUsingPlusPlus()
        {
            Assert.AreEqual(4, exercises.ReturnFourUsingPlusPlus());
        }

        [TestMethod]
        public void Test_13_ReturnFizzIfThree()
        {
            Assert.AreEqual("Fizz", exercises.ReturnFizzIfThree(3));
            Assert.AreEqual("", exercises.ReturnFizzIfThree(6));
        }

        [TestMethod]
        public void Test_14_ReturnFizzIfThreeUsingTernary()
        {
            Assert.AreEqual("Fizz", exercises.ReturnFizzIfThreeUsingTernary(3));
            Assert.AreEqual("", exercises.ReturnFizzIfThreeUsingTernary(6));
        }

        [TestMethod]
        public void Test_15_ReturnFizzOrBuzzOrNothing()
        {
            Assert.AreEqual("Fizz", exercises.ReturnFizzOrBuzzOrNothing(3));
            Assert.AreEqual("Buzz", exercises.ReturnFizzOrBuzzOrNothing(5));
            Assert.AreEqual("", exercises.ReturnFizzOrBuzzOrNothing(15));
        }

        [TestMethod]
        public void Test_16_ReturnAdultOrMinor()
        {
            Assert.AreEqual("Adult", exercises.ReturnAdultOrMinor(20));
            Assert.AreEqual("Adult", exercises.ReturnAdultOrMinor(18));
            Assert.AreEqual("Minor", exercises.ReturnAdultOrMinor(17));
        }

        [TestMethod]
        public void Test_17_ReturnAdultOrMinorAgain()
        {
            Assert.AreEqual("Adult", exercises.ReturnAdultOrMinorAgain(20));
            Assert.AreEqual("Adult", exercises.ReturnAdultOrMinorAgain(18));
            Assert.AreEqual("Minor", exercises.ReturnAdultOrMinorAgain(17));
        }

        [TestMethod]
        public void Test_18_ReturnAdultOrMinorReversed()
        {
            Assert.AreEqual("Adult", exercises.ReturnAdultOrMinorReversed(20));
            Assert.AreEqual("Adult", exercises.ReturnAdultOrMinorReversed(18));
            Assert.AreEqual("Minor", exercises.ReturnAdultOrMinorReversed(17));
        }
    }
}
