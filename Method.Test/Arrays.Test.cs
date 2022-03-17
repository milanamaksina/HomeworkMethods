using HW_Methods;
using NUnit.Framework;
using System;

namespace Method.Test
{
    public class ArraysTests
    {

        [TestCase(new int[] { 1, 2, 3, 4 }, 1)]
        [TestCase(new int[] { -7, 0, -9, 4 }, -9)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        public void FindMinValueTest(int[] array, int expected)
        {
            int actual = Arrays.FindMinValue(array);
            Assert.AreEqual(expected, actual);
        } //1 

        [TestCase(new[] { 1, 2, 3, 4 }, 4)]
        [TestCase(new[] { -9, -8, -10, -40 }, -8)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        public void FindMaxValueTest(int[] array, int expected)
        {
            int actual = Arrays.FindMaxValue(array);
            Assert.AreEqual(expected, actual);
        } //2

        [TestCase(new[] { 8, 2, 9, 1 }, 3)]
        [TestCase(new[] { -9, -8, -10, -40 }, 3)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        public void FindIndexOfMinValueTest(int[] array, int expected)
        {
            int actual = Arrays.FindIndexOfMinValue(array);
            Assert.AreEqual(expected, actual);
        } //3

        [TestCase(new[] { 9, 10, 22, 11 }, 2)]
        [TestCase(new[] { -9, -10, -22, -11 }, 0)]
        [TestCase(new[] { 0, 0, 0, 0 }, 0)]
        public void FindIndexOfMaxValueTest(int[] array, int expected)
        {
            int actual = Arrays.FindIndexOfMaxValue(array);
            Assert.AreEqual(expected, actual);
        } //4

        [TestCase(new[] { 10, 25, 30, 35, 40 }, 60)]
        [TestCase(new[] { -20, -25, 10, -5, -10 }, -30)]
        [TestCase(new[] { 0, 0, 0, 0 }, 0)]
        public void CalculateTheSumWithOddIndexiesTest(int[] array, int expected)
        {
            int actual = Arrays.CalculateTheSumWithOddIndexies(array);
            Assert.AreEqual(expected, actual);
        } //5


        [TestCase(new[] { 0, 0, 0, 0 }, new[] { 0, 0, 0, 0, })]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 4, 3, 2, 1 })]
        [TestCase(new[] { -1, -3, -6, -7 }, new[] { -7, -6, -3, -1 })]
        public void ReverseArraTest(int[] array, int[] expected)
        {
            int[] actual = Arrays.ReverseArray(array);
            Assert.AreEqual(expected, actual);
        } //6


        [TestCase(new int[] { 7, 9, 0, 2, 1, 3, 3, 4 }, 5)]
        [TestCase(new int[] { 2, 4, 6 }, 0)]
        [TestCase(new int[] { 0, 0, 0 }, 0)]
        [TestCase(new int[] { -1, -4, -7, 9 }, 3)]
        public void GetAmountOfOddElementsTest(int[] array, int expected)
        {
            int actual = Arrays.GetAmountOfOddElements(array);
            Assert.AreEqual(expected, actual);
        } //7


        [TestCase(new[] { 1, 4, 6, 5 }, new[] { 6, 5, 1, 4 })]
        [TestCase(new[] { 7, 8, 9, 1, 2 }, new[] { 1, 2, 9, 7, 8 })]
        [TestCase(new[] { -8, -9, 5, -1, -2 }, new[] { -1, -2, 5, -8, -9 })]
        public void SwapHalfTest(int[] array, int[] expected)
        {
            int[] actual = Arrays.SwapHalf(array);
            Assert.AreEqual(expected, actual);
        } //8


        [TestCase(new[] { 1, 4, 6, 5 }, new[] { 1, 4, 5, 6 })]
        [TestCase(new[] { 7, 8, 9, 1, 2 }, new[] { 1, 2, 7, 8, 9 })]
        [TestCase(new[] { -8, -9, 5, -1, -2 }, new[] { -9, -8, -2, -1, 5 })]
        [TestCase(new[] { -1, -2, 3, 0 }, new[] { -2, -1, 0, 3 })]
        public void SortAscendinTest(int[] array, int[] expected)
        {
            int[] actual = Arrays.SortAscending(array);
            Assert.AreEqual(expected, actual);
        } //9


        [TestCase(new[] { 1, 4, 6, 5 }, new[] { 6, 5, 4, 1 })]
        [TestCase(new[] { 7, 8, 9, 1, 2 }, new[] { 9, 8, 7, 2, 1 })]
        [TestCase(new[] { -8, -9, 5, -1, -2 }, new[] { 5, -1, -2, -8, -9})]
        [TestCase(new[] { -1, -2, 3, 0 }, new[] { 3, 0, -1, -2})]
        public void SortDescendingTest(int [] array, int[] expected)
        {
            int[] actual = Arrays.SortDescending(array);
            Assert.AreEqual(expected, actual);
        } //10

    }
}
