namespace HW_Methods
{
    internal class Arrays
    {
        public static void WriteArray(int [] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }

        }
        public static int[] GenerateArray(int lenght, int min = -100, int max = 100)
        {
            Random r = new Random();

            int[] array = new int[lenght];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = r.Next(min, max);
            }
            return array;
        }
        public static int[] CopyArray(int[] array)
        {
            int[] newArray = new int[array.Length];
            Array.Copy(array, newArray, array.Length);
            return newArray;
        }
        public static int FindMinValue(int[] array)
        {
            int minValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            return minValue;
        }
        public static int FindMaxValue(int[] array)
        {
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            return maxValue;
        }
        public static int FindIndexOfMinValue(int[] array)
        {
            int minValue = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minValue)
                {
                    minValue = array[i];
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == minValue)
                {
                    return j;
                }
            }
            return -1;
        }
        public static int FindIndexOfMaxValue(int[] array)
        {
            int maxValue = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                }
            }
            for (int j = 0; j < array.Length; j++)
            {
                if (array[j] == maxValue)
                {
                    return j;
                }
            }
            return -1;
        }
        public static int CalculateTheSumWithOddIndexies(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 1)
                {
                    sum += array[i];
                }

            }
            return sum;

        }
        public static int[] ReverseArray(int[] array)
        {
            int[] result = CopyArray(array);
            for (int i = 0; i < result.Length / 2; i++)
            {
                int tmp = result[i];
                result[i] = result[result.Length - (1 + i)];
                result[result.Length - (1 + i)] = tmp;
            }
            return result;
        }
        public static int GetAmountOfOddElements(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0)
                {
                    sum++;
                }
            }
            return sum;
        } //7
        public static int[] SwapHalf(int[] array)
        {
            int[] result = CopyArray(array);

            int n = result.Length / 2;
            int step = n + result.Length % 2;
            for (int i = 0; i < n; i++)
            {
                int tmp = result[i];
                result[i] = result[i + step];
                result[i + step] = tmp;
            }
            return result;
        } //8
        public static int[] SortAscending(int[] array)
        {
            int[] result = CopyArray(array);
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
            Console.WriteLine();
            return result;
        } //9
        public static int[] SortDescending(int[] array)
        {
            int tmp;
            for (int i = 0; i < array.Length; i++)
            {
                int index = i;
                tmp = array[i];
                while (index > 0 && tmp > array[index - 1])
                {
                    array[index] = array[index - 1];
                    index--;
                }
                array[index] = tmp;
            }
                Console.WriteLine();
                 return array;
        } //10

    }
}