using HW_Methods;
using NUnit.Framework;
using System;


namespace Method.Test
{
    public class VariablesTests
    {

        [TestCase(10, 5, 2, 0)]
        [TestCase(-11, -3, 3, -2)]
        [TestCase(0, 5, 0, 0)]
        public void GetResultOfDivisionAndRemainderTest(int a, int b, int expectedDivision, int expectedRemainder)
        {
            int actualDivision;
            int actualRemainder;
            Variables.GetResultOfDivisionAndRemainder(a, b, out actualDivision, out actualRemainder);
            Assert.AreEqual(expectedDivision, actualDivision);
            Assert.AreEqual(expectedRemainder, actualRemainder);
        } //1

        [TestCase(9,0)]
        [TestCase(-9,0)]
        public void GetResultOfDivisionAndRemainderTest_WhenAequalZero_ShouldThrowExeption(int a, int b)
        {
            Assert.Throws<Exception>(() => Variables.GetResultOfDivisionAndRemainder(a, b, out int division, out int remainder));
        } //1

        [TestCase(5, 10, 25)]
        [TestCase(-2, 3, -0.2)]
        [TestCase(-5, -10, -15)]
        [TestCase(5, 0, -5)]
        public void GetResultOftheExpressionTest(double a, double b, double expected)
        {
            double actual = Variables.GetResultOftheExpression(a, b);
            Assert.AreEqual(expected, actual);
        } //2
        
        [TestCase(0, 0)]
        public void GetResultOftheExpressionTest_WhenAAndBAreEqual0_ShouldThrowExeption(double a, double b)
        {
            Assert.Throws<Exception>(()=>Variables.GetResultOftheExpression(a, b));
        } //2

        [TestCase("Hello","World","World","Hello")]
        [TestCase("11","22","22","11")]
        [TestCase(" ","7","7"," ")]
        public void SwapTest(string a, string b, string expectedA, string expectedB)
        {
            Variables.Swap(ref a, ref b);
            Assert.AreEqual(expectedA, a);
            Assert.AreEqual(expectedB, b);
        } // 3

        [TestCase(-18, -2, 15, -0.94444444444444442d)]
        [TestCase(10, 5, 35, 3)]
        [TestCase(-2, 15, 5, 5)]
        [TestCase(-5,-5,0,-1)]
        public void FindXLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual = Variables.FindXLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);

        } //4

        [TestCase(0,5,10)]
        [TestCase(0,0,0)]
        public void FindXLinearEquationTest_WhenAAreEqual0_ShouldThrowExeption(double a, double b, double c)
        {
            Assert.Throws<Exception>(()=>Variables.FindXLinearEquation(a, b, c));
        } //4


        public void GetStraightLineEquationTest(double x1, double y1, double x2, double y2, string expected)
        {
            string actuale = Variables.GetStraightLineEquation(x1, y1, x2, y2);
            Assert.AreEqual(expected, actuale);
        }
    }   //5 ?
}