using HW_Methods;
using NUnit.Framework;
using System;

namespace Method.Test
{
    public class TwoDArraysTests
    {
        [TestCase(TDAMockType.TwoDMockType.Positive, 1)]
        [TestCase(TDAMockType.TwoDMockType.Negative, -15)]
        [TestCase(TDAMockType.TwoDMockType.AllNumbers, -9)]
        [TestCase(TDAMockType.TwoDMockType.Zeros, 0)]
        //[TestCase(TDAMockType.TwoDMockType.Empty,)]
        public void FindMinValue2DTest(TDAMockType.TwoDMockType type, int expected)
        {
            int[,] array = TDAMockType.GetMock(type);
            int actual = TwoDimensionalArray.FindMinValue2D(array);
            Assert.AreEqual(expected, actual);
        } //1

        [TestCase(TDAMockType.TwoDMockType.Positive, 16)]
        [TestCase(TDAMockType.TwoDMockType.Negative, -1)]
        [TestCase(TDAMockType.TwoDMockType.AllNumbers, 443)]
        [TestCase(TDAMockType.TwoDMockType.Zeros, 0)]
        public void FindMaxValue2DTest(TDAMockType.TwoDMockType type, int expected)
        {
            int[,] array = TDAMockType.GetMock(type);
            int actual = TwoDimensionalArray.FindMaxValue2D(array);
            Assert.AreEqual(expected, actual);
        } //2

        [TestCase(TDAMockType.TwoDMockType.Positive, new[] { 0, 0 })]
        [TestCase(TDAMockType.TwoDMockType.Negative, new[] { 3, 3 })]
        [TestCase(TDAMockType.TwoDMockType.AllNumbers, new[] { 3, 3 })]
        [TestCase(TDAMockType.TwoDMockType.Zeros, new[] { 3, 3 })]
        public void FindIndexOfMinValueTest(TDAMockType.TwoDMockType type, int[] expected)
        {
            int[,] array = TDAMockType.GetMock(type);
            int[] actual = TwoDimensionalArray.FindIndexOfMinValue(array);
            Assert.AreEqual(expected, actual);
        } //3

        [TestCase(TDAMockType.TwoDMockType.Positive, new[] { 3, 3 })]
        [TestCase(TDAMockType.TwoDMockType.Negative, new[] { 0, 0 })]
        [TestCase(TDAMockType.TwoDMockType.AllNumbers, new[] { 1, 2 })]
        [TestCase(TDAMockType.TwoDMockType.Zeros, new[] { 3, 3 })]
        public void FindIndexOfMaxValueTest(TDAMockType.TwoDMockType type, int[] expected)
        {
            int[,] array = TDAMockType.GetMock(type);
            int[] actual = TwoDimensionalArray.FindIndexOfMaxValue(array);
            Assert.AreEqual(expected, actual);
        } //4


        [TestCase(TDAMockType.TwoDMockType.Positive, 1)]
        [TestCase(TDAMockType.TwoDMockType.Negative, 1)]
        [TestCase(TDAMockType.TwoDMockType.AllNumbers, 4)]
        [TestCase(TDAMockType.TwoDMockType.Zeros, 0)]
        public void CountElementsHigherThanNeighborTest(TDAMockType.TwoDMockType type, int expected)
        {
            int[,] array = TDAMockType.GetMock(type);
            int actual = TwoDimensionalArray.CountElementsHigherThanNeighbor(array);
            Assert.AreEqual(expected, actual);
        } //5


        [TestCase(TDAMockType.TwoDMockType.Positive, TDAMockType.TwoDMockType.PositiveReflected)]
        [TestCase(TDAMockType.TwoDMockType.Negative, TDAMockType.TwoDMockType.NegativeReflected)]
        public void ReflectTest(TDAMockType.TwoDMockType type, TDAMockType.TwoDMockType expectedType)
        {
            int[,] array = TDAMockType.GetMock(type);
            int[,] expected = TDAMockType.GetMock(expectedType);
            int[,] actual = TwoDimensionalArray.Reflect(array);
            Assert.AreEqual(expected, actual);
        } //6


    }


}
