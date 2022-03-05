﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Methods
{
    internal class IfElse
    {
        public static int CalculateTheNumbers(int a, int b)
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
                result = "1 кординатная четверть";
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
            else
            {
                result = "Точка является началом координаты";
            }

            return (result);
        }

        public static string PutInAscendingOrder(ref int a, ref int b, ref int c)
        {
            string result;

            if (a < b && b < c)
            {
                result = ($"По возрастанию:{a} {b} {c}");
            }
            else if (b < a && a < c)
            {
                result = ($"По возрастанию:{b} {a} {c}");
            }
            else if (c < a && a < b)
            {
                result = ($"По возрастанию:{c} {a} {b}");
            }
            else if (b < c && c < a)
            {
                result = ($"По возрастанию:{b} {c} {a}");
            }
            else if (c < b && b < a)
            {
                result = ($"По возрастанию:{c} {b} {a}");
            }
            else if (a == b && c > a)
            {
                result = ($"По возрастанию:{a} {b} {c}");
            }
            else if (a == c && b > a)
            {
                result = ($"По возрастанию:{a} {c} {b}");
            }
            else if (b == c && a > c)
            {
                result = ($"По возрастанию:{b} {c} {a}");
            }
            else
            {
                result = ($"По возрастанию:{a} {b} {c}");
            }
            return result;
        }

        public static string Reshi(ref double a, ref double b, ref double c)
        {
            string result;
            double discriminant = (b * b) - 4 * a * c;
            double rootD = Math.Sqrt(discriminant);
            double x1 = (-b + rootD) / (2 * a);
            double x2 = (-b - rootD) / (2 * a);
            if (discriminant > 0)
            {
                result = ($"х1 = {x1}  x2= {x2}");
            }
            else if (discriminant < 0)
            {
                result = ("Уравнение не имеет корней");
            }
            else
            {
                result = ($"X={-b / (2 * b)}");
            }
            return result;
        }

        public static string  GetDoubleFiguresInLetters (int a)
        {
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
