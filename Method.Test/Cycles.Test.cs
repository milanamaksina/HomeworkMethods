using HW_Methods;
using NUnit.Framework;
using System;


namespace Method.Test
{
    public class CyclesTests
    {
        [TestCase(2, 5, 32)]
        [TestCase(16, -3, -4096)]
        [TestCase(0, 0, 1)]
        [TestCase(-5, -5, 3125)]
        public void RaiseOneNumberToThePowerOfAnotherTest(int a, int b, int expected)
        {
            int actual = Cycles.RaiseOneNumberToThePowerOfAnother(a, b);
            Assert.AreEqual(expected, actual);
        } //1

        [TestCase(200, new int[] { 200, 400, 600, 800, 1000 })]
        [TestCase(1000, new int[] { 1000 })]
        public void GetDivisibleNumbersTest(int n, int[] expected)
        {
            int[] actual = Cycles.GetDivisibleNumbers(n);
            Assert.AreEqual(expected, actual);
        } //2

        [TestCase(0)]
        [TestCase(-5)]
        [TestCase(1002)]
        public void GetDivisibleNumbersTest_WhenNLess1More1000_ShouldThrowExeption(int n)
        {
            Assert.Throws<Exception>(() => Cycles.GetDivisibleNumbers(n));
        } //2

        [TestCase(20, 4)]
        [TestCase(2, 1)]
        public void GetTheAmountOfNumbersTest(int a, int expected)
        {
            int actual = Cycles.GetTheAmountOfNumbers(a);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(0)]
        [TestCase(-20)]
        public void GetTheAmountOfNumbersTest_WhenAlessThanOne_ShouldThrowExeption(int a)
        {
            Assert.Throws<Exception>(() => Cycles.GetTheAmountOfNumbers(a));

        } //3

        [TestCase(20, 10)]
        [TestCase(100, 50)]
        [TestCase(2, 1)]
        public void FindTheLargestDivisorTest(int a, int expected)
        {
            int actual = Cycles.FindTheLargestDivisor(a);
            Assert.AreEqual(expected, actual);
        } //4

        [TestCase(-5)]
        [TestCase(0)]
        public void FindTheLargestDivisorTest_WhenAless1_ShouldThrowExeption(int a)
        {
            Assert.Throws<Exception>(() => Cycles.FindTheLargestDivisor(a));
        } //4

        [TestCase(-8, 15, 14)]
        [TestCase(-28, 0, -70)]
        [TestCase(0, 0, 0)]
        [TestCase(1, 15, 21)]
        public void GetSumOfNumbersDivisibleBy7Test(int a, int b, int expected)
        {
            int actual = Cycles.GetSumOfNumbersDivisibleBy7(a, b);
            Assert.AreEqual(expected, actual);
        } //5

        [TestCase(20, 6765)]
        [TestCase(10, 55)]
        [TestCase(1, 1)]
        public void PrintTheFibonacciNumberTest(int n, int expected)
        {
            int actual = Cycles.PrintTheFibonacciNumber(n);
            Assert.AreEqual(expected, actual);
        } //6

        [TestCase(-10)]
        [TestCase(0)]
        public void PrintTheFibonacciNumberTest_WhenNless0_ShouldThrowExeption(int n)
        {
            Assert.Throws<Exception>(() => Cycles.PrintTheFibonacciNumber(n));
        } //6

        [TestCase(15, 95, 5)]
        [TestCase(30, 18, 6)]
        [TestCase(-30, 25, 5)]
        [TestCase(25, -125, 25)]
        public void FindTheGreatestCommonDivisor(int a, int b, int expected)
        {
            int actual = Cycles.FindTheGreatestCommonDivisor(a, b);
            Assert.AreEqual(expected, actual);
        } //7

        [TestCase(0, 15)]
        [TestCase(10, 0)]
        [TestCase(0, 0)]
        public void FindTheGreatestCommonDivisor(int a, int b)
        {
            Assert.Throws<Exception>(() => Cycles.FindTheGreatestCommonDivisor(a, b));
        } //7

        

    }

}