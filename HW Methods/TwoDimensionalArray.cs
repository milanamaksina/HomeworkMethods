namespace HW_Methods
{
    internal class TwoDimensionalArray
    {
        public static int FindMinValue2D(int[,] array)
        {
            int min = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            return min;
        }
        public static int FindMaxValue2D(int[,] array)
        {
            int max = array[0, 0];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                    }
                }
            }
            return max;
        }
        public static int [] FindIndexOfMinValue(int[,] array)
        {
            int min = array[0, 0];
            int [] result = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                    }
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == min)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }

            }
            return result;
        }
        public static int[] FindIndexOfMaxValue(int[,] array)
        {
            int max = array[0, 0];
            int[] result = new int[2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] < max)
                    {
                        max = array[i, j];
                    }
                }
            }
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (array[i, j] == max)
                    {
                        result[0] = i;
                        result[1] = j;
                    }
                }

            }
            return result;
        }
        public static int[,] Generate2DArray(int a, int b, int min = -100, int max = 100)
        {
            int[,] newArray = new int[a, b];
            Random random = new Random();
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    newArray[i, j] = random.Next(min, max);
                }
            }
            return newArray;
        }
        public static void Write2DArray(int[,] array)
        {
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }

}
