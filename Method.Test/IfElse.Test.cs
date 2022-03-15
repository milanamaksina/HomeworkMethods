using NUnit.Framework;
using System;
using HW_Methods;


namespace Method.Test
{
    public class IfElseTests
    {

        [TestCase(20, 10, 30)]
        [TestCase(0, -15, -15)]
        [TestCase(0, 0, 0)]
        [TestCase(10, 10, 100)]
        [TestCase(-15, -15, 225)]
        [TestCase(10, 20, -10)]
        [TestCase(0, 10, -10)]
        [TestCase(-5, -2, -3)]
        public void CountNumbersTest(int a, int b, int expected)
        {
            int actual = IfElse.CountNumbers(a, b);
            Assert.AreEqual(expected, actual);
        }

        [TestCase(5, 9, "1 координатная четверть")]
        [TestCase(-5, 9, "2 координатная четверть")]
        [TestCase(-2, -3, "3 координатная четверть")]
        [TestCase(3, -3, "4 координатная четверть")]
        [TestCase(0, -3, "точка лежит на оси ординат")]
        [TestCase(0, 4, "точка лежит на оси ординат")]
        [TestCase(-2, 0, "точка лежит на оси абсцисс")]
        [TestCase(0, 0, "точка является началом координаты")]
        public void DetermineTheCoordinateQuarterTest(int x, int y, string expected)
        {
            string actual = IfElse.DetermineTheCoordinateQuarter(x, y);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(1, 2, 3, new int [] { 1, 2, 3})]
        [TestCase(-1,-2, 3, new int [] {-2, -1, 3})]
        [TestCase(0,0,0, new int [] { 0, 0, 0})]
        public void PutInAscendingOrderTest(int a, int b, int c, int [] expected)
        {
            int[] actual = IfElse.PutInAscendingOrder(a, b, c);
            Assert.AreEqual(expected, actual);
        }

    }
}
