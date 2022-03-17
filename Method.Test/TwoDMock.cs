using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HW_Methods;

namespace Method.Test
{
    public class TDAMockType
    {
        public enum TwoDMockType
        {
            Positive,
            PositiveReflected,
            Negative,
            NegativeReflected,
            Zeros,
            AllNumbers,
            AllNumbersReflected,
            Empty
        }
        public static int [,] GetMock(TwoDMockType type)
        {
            switch (type)
            {
                case TwoDMockType.Positive:
                    return new int[,]
                    {
                        {1,2,3,4 },
                        {5,6,7,8},
                        {9,10,11,12},
                        {13,14,15,16},
                    };

                case TwoDMockType.Negative:
                    return new int[,]
                    {
                        {-1,-2,-3,-4 },
                        {-4, -5, -6, -7 },
                        {-8,-9,-10,-11},
                        {-12,-13,-14,-15 },

                    };

                case TwoDMockType.Zeros:
                    return new int[,]
                    {
                        {0,0,0,0},
                        {0,0,0,0},
                        {0,0,0,0},
                        {0,0,0,0},
                    };

                case TwoDMockType.AllNumbers:
                    return new int[,]
                    {
                        {1,3,-3,5},
                        {83,9,443,4},
                        {2,100,-1,-4},
                        {6,8,8,-9},
                    };

                case TwoDMockType.PositiveReflected:
                    return new int[,]
                    {
                        {1,5,9,13},
                        {2,6,10,14},
                        {3,7,11,15},
                        {4,8,12,16},
                    };
                case TwoDMockType.NegativeReflected:
                    return new int[,]
                    {
                        {-1,-4,-8,-12},
                        {-2, -5, -9, -13 },
                        {-3,-6,-10,-14},
                        {-4,-7,-11,-15 },

                    };
                case TwoDMockType.Empty:
                    return new int[,] { };

                default:
                    throw new Exception();
            }
        }
    }
}
