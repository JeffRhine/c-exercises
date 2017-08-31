using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MorningExercises.Tests
{
    [TestClass]
    public class ValidationTests
    {
        private Exercise exercises = new Exercise();

        [TestMethod]
        public void Test_1_ReturnArray()
        {
            CollectionAssert.AreEqual(new int[] { 80, 8080, 443 }, exercises.ReturnArray());
        }

        [TestMethod]
        public void Test_2_ReturnFirstElement()
        {
            Assert.AreEqual(80, exercises.ReturnFirstElement(), "That's not the first element in that array");
        }

        [TestMethod]
        public void Test_3_ReturnLastElement()
        {
            Assert.AreEqual(443, exercises.ReturnLastElement(), "That's not the last element");
        }

        [TestMethod]
        public void Test_4_ReturnFirstElementOfParam()
        {
            Assert.AreEqual(5, exercises.ReturnFirstElementOfParam(new int[] { 5, 10, 15 }), "That's not the first element from {5, 10, 15}");
            Assert.AreEqual(10, exercises.ReturnFirstElementOfParam(new int[] { 10, 20, 30, 40, 50 }), "That's not the first element from {10, 20, 30, 40, 50}");
        }

        [TestMethod]
        public void Test_5_01_ReturnLastElementOfParam()
        {
            Assert.AreEqual(15, exercises.ReturnLastElementOfParam(new int[] { 5, 10, 15 }), "That's not the last element from {5, 10, 15}");
            Assert.AreEqual(50, exercises.ReturnLastElementOfParam(new int[] { 10, 20, 30, 40, 50 }), "That's not the last element from {10, 20, 30, 40, 50}");
        }

        [TestMethod]
        public void Test_5_02_ReturnFixedArray()
        {
            Assert.IsNotNull(exercises.ReturnFixedArray(), "Make sure the thing you are returning is not null.");
            Assert.AreEqual(5, exercises.ReturnFixedArray().Length, "The array returned should be size 5");
        }

        [TestMethod]
        public void Test_5_03_ReturnDynamicallySizedArray()
        {
            Assert.IsNotNull(exercises.ReturnDynamicallySizedArray(0), "Make sure the thing you are returning is not null.");
            Assert.AreEqual(5, exercises.ReturnDynamicallySizedArray(5).Length, "The array returned should be size 5");
            Assert.AreEqual(10, exercises.ReturnDynamicallySizedArray(10).Length, "The array returned should be size 10");
        }

        [TestMethod]
        public void Test_6_ReturnVariableFromBlock()
        {
            Assert.AreEqual(15, exercises.ReturnVariableFromBlock(3));
        }

        [TestMethod]
        public void Test_7_ReturnOperationInBlock()
        {
            Assert.IsTrue(exercises.ReturnOperationInBlock(), "Not true yet!");
        }

        [TestMethod]
        public void Test_8_ReturnInScopeVariable()
        {
            Assert.AreEqual(5.0, exercises.ReturnInScopeVariable(), 0.001, "Not that one, try again.");
        }

        [TestMethod]
        public void Test_9_ReturnCounterFromLoop()
        {
            Assert.IsTrue(exercises.ReturnCounterFromLoop(), "Not true yet!");
        }

        [TestMethod]
        public void Test_10_ReturnCorrectCount()
        {
            Assert.IsTrue(exercises.ReturnCorrectCount(), "Not Correct Yet!");
        }

        [TestMethod]
        public void Test_11_ReturnCountCorrectTimes()
        {
            Assert.IsTrue(exercises.ReturnCountCorrectTimes(), "Not Correct Yet!");
        }

        [TestMethod]
        public void Test_12_ReturnSumEveryOtherNumber()
        {
            Assert.IsTrue(exercises.ReturnSumEveryOtherNumber(), "Not Correct Yet!");
        }
    }
}
