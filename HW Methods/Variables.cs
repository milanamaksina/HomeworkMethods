using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Methods
{
    public class Variables
    {
        public static void GetResultOfDivisionAndRemainder(int a, int b, out int division, out int remainder)
        {
            if (b == 0)
            {
                throw new Exception("b can't be 0");
            }
            division = a / b;
            remainder = a % b;
        } //1
        public static void Swap(ref string a, ref string b)
        {
            string tmp;
            tmp = a;
            a = b;
            b = tmp;
        } //3
        public static double GetResultOftheExpression(double a, double b)
        {
            if(a == 0 && b == 0)
            {
                throw new Exception("a and b cannot equal 0");
            }
            double result = (5 * a + b * b) / (b - a);
            return Math.Round(result, 2);
        } //2
        public static double FindXLinearEquation(double a, double b, double c)
        {
            if (a == 0)
            {
                throw new Exception("a cannot equal 0");
            }
            double x = (c - b) / a;
            return Math.Round(x, 2);
        } //4

        public static string GetStraightLineEquation(double x1, double y1, double x2, double y2)
        {
            double pointA = (y1 - y2) / (x1 - x2);
            double pointB = y2 - pointA * x2;
            string point1 = Convert.ToString(Math.Round(pointA,2));
            string point2 = Convert.ToString(Math.Round(pointB, 2));
            string result = ($"Y={ point1 }X+{point2}");
            return result;

        }

        

    }

}


























