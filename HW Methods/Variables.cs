using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Methods
{
    static class Variables
    {
        public static void GetResultOfDivisionAndRemainder(int a, int b, out int result, out int remainder)
        {
            if (b == 0)
            {
                throw new Exception("b can't be 0");
            }
            result = a / b;
            remainder = a % b;
        } //1

        public static void Swap(ref string a, ref string b)
        {
            if (a == b)
            {
                throw new Exception("a cannot equal b");
            }
            string tmp;
            tmp = a;
            a = b;
            b = tmp;
        } //3

        public static int GetResultOftheExpression(int a, int b)
        {
            int result = (5 * a + b * b) / (b - a);
            return result;
        } //2

        public static double FindXLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a cannot equal b");
            }
            double x = (c - b) / a;
            return x;
        } //4
        public static string GetStraightLineEquation(double x1, double y1, double x2, double y2)
        {
            double pointA = (y1 - y2) / (x1 - x2);
            double pointB = y2 - pointA * x2;
            string point1 = Convert.ToString(pointA);
            string point2 = Convert.ToString(pointB);
            string result = ($" { point2 } {point1}");
            return result;

        }



    }

}


























