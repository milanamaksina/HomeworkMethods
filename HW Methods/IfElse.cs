using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Methods
{
    public class IfElse
    {
        public static int CountNumbers(int a, int b)
        {
            int result;

            if (a > b)
            {
                result = a + b;
            }
            else if (a == b)
            {
                result = a * b;
            }
            else
            {
                result = a - b;
            }
            return result;
        }
     
        public static string DetermineTheCoordinateQuarter(int x, int y)
        {
            string result;
            if (x > 0 && y > 0)
            {
                result = "1 координатная четверть";
            }
            else if (x < 0 && y > 0)
            {
                result = "2 координатная четверть";
            }
            else if (x < 0 && y < 0)
            {
                result = "3 координатная четверть";
            }
            else if (x > 0 && y < 0)
            {
                result = "4 координатная четверть";
            }
            else if (x == 0 && y != 0)
            {
                result = "точка лежит на оси ординат";
            }
            else if (y == 0 && x != 0)
            {
                result = "точка лежит на оси абсцисс";
            }
            else
            {
                result = "точка является началом координаты";
            }

            return (result);
        }

        public static int [] PutInAscendingOrder(int a, int b, int c)
        {
            int [] result = { a, b, c };
            int tmp;
            for (int i = 0; i < result.Length; i++)
            {
                for (int j = 0; j < result.Length - 1 - i; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        tmp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = tmp;
                    }

                }
            }
            return result;
        }

        public static double [] FindXQuadricEquation(double a, double b, double c)
        {
            if (a == 0 && b == 0)
            {
                throw new Exception("a and b cannot equal 0");
            }
            double[] result1 = new double[2];
            double[] result2 = new double[1];
            double discriminant = (b * b) - 4 * a * c;
            double rootD = Math.Sqrt(discriminant);

            if (discriminant > 0)
            {
                result1[0] = (-b - rootD) / (2 * a);
                result1[1] = (-b + rootD) / (2 * a);
                return result1;
            }
            else if (discriminant < 0)
            {
                result2[0] = 0;
                return result2;
            }
            else
            {
                result2[0] = -b / (2 * a);
                return result2;
            }

        }

        public static string GetDoubleFiguresInLetters(int a)
        {
            if (a < 10 || a > 99)
            {
                throw new Exception("Error");
            }
            int decade = a / 10;
            int unit = a % 10;
            string name = "";
            if (a >= 20)
            {
                switch (decade)
                {
                    case 2:
                        name += "двадцать";
                        break;
                    case 3:
                        name += "тридцать";
                        break;
                    case 4:
                        name += "сорок";
                        break;
                    case 5:
                        name += "пятьдесят";
                        break;
                    case 6:
                        name += "шестьдесят";
                        break;
                    case 7:
                        name += "семьдесят";
                        break;
                    case 8:
                        name += "восемьдесят";
                        break;
                    case 9:
                        name += "девяносто";
                        break;
                }
                switch (unit)
                {
                    case 1:
                        name += " один";
                        break;
                    case 2:
                        name += " два";
                        break;
                    case 3:
                        name += " три";
                        break;
                    case 4:
                        name += " четыре";
                        break;
                    case 5:
                        name += " пять";
                        break;
                    case 6:
                        name += " шесть";
                        break;
                    case 7:
                        name += " семь";
                        break;
                    case 8:
                        name += " восемь";
                        break;
                    case 9:
                        name += " девять";
                        break;
                }

            }
            else 
            {
                switch (a)
                {
                    case 10:
                        name = "десять";
                        break;
                    case 11:
                        name = "одиннадцать";
                        break;
                    case 12:
                        name = "двенадцать";
                        break;
                    case 13:
                        name = "тринадцать";
                        break;
                    case 14:
                        name = "четырнадцать";
                        break;
                    case 15:
                        name = "пятнадцать";
                        break;
                    case 16:
                        name = "шестнадцать";
                        break;
                    case 17:
                        name = "семнадцать";
                        break;
                    case 18:
                        name = "восемнадцать";
                        break;
                    case 19:
                        name = "девятнадцать";
                        break;


                }
            }

            return name;


        }

    }

}
