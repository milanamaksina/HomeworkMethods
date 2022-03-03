using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Methods
{
    static class Variables
    {
        public static int GetResultOftheExpression(int a, int b)
        {
            int result = (5 * a + b * b) / (b - a);
            return result;
        }

        public static int FindXLinearEquation(int a, int b, int c)
        {
            int x = (c - b) / a;
            return x;
        }
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


























