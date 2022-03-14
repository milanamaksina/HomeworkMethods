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
        public static int[,] CopyArray(int[,] numbers)
        {
            int[,] copyArray = new int[numbers.GetLength(0), numbers.GetLength(1)];
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    copyArray[i, j] = numbers[i, j];
                }
            }
            return copyArray;
        }
        public static int[] FindIndexOfMinValue(int[,] array)
        {
            int min = array[0, 0];
            int[] result = new int[2];
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
        public static int CountElementsHigherThanNeighbor(int[,] array)
        {
            int count = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (
                        (i == 0 || array[i, j] > array[i - 1, j])
                        && (i == array.GetLength(0) - 1 || array[i, j] > array[i + 1, j])
                        && (j == 0 || array[i, j] > array[i, j - 1])
                        && (j == array.GetLength(1) - 1 || array[i, j] > array[i, j + 1])
                        )
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public static int[,] Reflect(int[,] array)
        {
            int[,] result = CopyArray(array);
            int temp;
            for (int i = 1; i < result.GetLength(0); i++)
            {
                for (int j = 0; j < i; j++)
                {
                    temp = result[i, j];
                    result[i, j] = result[j, i];
                    result[j, i] = temp;
                }
            }
            return result;

        }
    }

}
