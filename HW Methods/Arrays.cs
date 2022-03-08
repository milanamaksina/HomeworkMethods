namespace HW_Methods
{
    internal class Arrays
    {
        public static void WriteArray(int[] a)
        {
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i] + " ");
            }

        }
        public static int[] GenerateArray(int lenght)
        {
            Random r = new Random();

            int[] a = new int[lenght];
            for (int i = 0; i < a.Length; i++)
            {
                a[i] = r.Next(100);
            }
            return a;
        }

        public static int FindMinValue()
        {
            int[] array = Arrays.GenerateArray(100);
            WriteArray(array);
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
        public static int FindMaxValue()
        {
            int[] array = Arrays.GenerateArray(100);
            WriteArray(array);
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
        public static int FindIndexOfMinValue()
        {
            int[] array = Arrays.GenerateArray(10);
            WriteArray(array);
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
        public static int FindIndexOfMaxValue()
        {
            int[] array = Arrays.GenerateArray(100);
            WriteArray(array);
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
        public static int CalculateTheSumOfOddElements()
        {
            int[] array = Arrays.GenerateArray(10);
            WriteArray(array);
            int sum = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                sum += array[i];
            }
            return sum;

        }

        public static void ReverseArray()
        {
            int[] array = Arrays.GenerateArray(100);
            WriteArray(array);
            for (int i = array.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(array[i] + " ");
            }

        }

        public static int GetAmountOfOddElements()
        {
            int[] array = Arrays.GenerateArray(10);
            WriteArray(array);
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



    }
}
