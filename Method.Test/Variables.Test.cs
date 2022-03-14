using HW_Methods;
using NUnit.Framework;
using System;


namespace Method.Test
{
    public class VariablesTests
    {

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

        [TestCase(-18, -2, 15, -0.94444444444444442d)]
        [TestCase(10, 5, 35, 3)]
        [TestCase(-2, 15, 5, 5)]
        [TestCase(-5,-5,0,-1)]
        public void FindXLinearEquationTest(double a, double b, double c, double expected)
        {
            double actual = Variables.FindXLinearEquation(a, b, c);
            Assert.AreEqual(expected, actual);

        }

        [TestCase(0,5,10)]
        [TestCase(0,0,0)]
        public void FindXLinearEquationTest_WhenABCAreEqual0_ShouldThrowExeption(double a, double b, double c)
        {
            Assert.Throws<Exception>(()=>Variables.FindXLinearEquation(a, b, c));
        }

    }   
}