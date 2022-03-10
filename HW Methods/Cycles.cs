namespace HW_Methods
{
    internal class Cycles
    {
        public static int RaiseOneNumberToThePowerOfAnother(int a, int b) //1 
        {
            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            return result;
        }

        static public int[] GetDivisibleNumbers(int n)
        {
            int[] temp = new int[1000/n];
            int b = 0;
            for (int i = 1; i < 1000; i++)
            {
                if (i % n == 0)
                {
                    temp[b] = i;
                    b++;    
                }

            }
            return temp;
        } //2

        public static int FindTheNumbersLessThanSquare(int a) // 3
        {
            int amount = 0;
            for (int i = 1; i < a; i++)
            {
                int square = i * i;

                if (square < a)
                {
                    amount++;
                }

            }
            return amount;

        }

        public static int FindTheLargestDivisor(int a)
        {
            int remainder;
            int result = 1;
            for (int i = 1; i < a; i++)
            {
                remainder = a % i;

                if (remainder == 0)
                {
                    result = i;
                }
            }
            return result;
        } // 4

        public static int GetSumOfNumbersDivisibleBy7(int a, int b)
        {
            int sum = 0;
            int tmp;
            if (b < a)
            {
                tmp = b;
                b = a;
                a = tmp;
            }
            for (int i = a; i <= b; i++)
            {
                if (i % 7 == 0)
                {
                    sum += i;
                }
            }

            return sum;
        } //5

        public static int PrintTheFibonacciNumber(int n)
        {
            if (n < 0)
            {
                throw new Exception("Error");
            }
            int numb1 = 1;
            int numb2 = 1;
            int amount = 0;
            int i = 2;
            while (i <= n)
            {
                amount = numb1 + numb2;
                numb1 = numb2;
                numb2 = amount;
                i++;
            }
            return numb1;
        } //6

        public static int FindTheGreatestCommonDivisor(int a, int b)
        {
            int nod;
            a = Math.Abs(a);
            b = Math.Abs(b);
            if (b == 0)
            {
                throw new Exception("Ошибка");
            }
            while (a != 0 && b != 0)
            {
                if (a > b)
                {
                    a = a % b;
                }
                else
                {
                    b = b % a;
                }
            }
            nod = a + b;
            return nod;
        } //7

        public static int FindNumber(int n)
        {
            int left = 0;
            int right = n;
            int tmp = 0;
            while (left * left * left != n && right * right * right != n)
            {
                tmp = (left + right) / 2;

                if (tmp * tmp * tmp >= n)
                {
                    right = tmp;
                }
                else
                {
                    left = tmp;
                }
            }
            return right;
        } //8

        public static int FindTheNumberOfOddDigits(int a)
        {
            int tmp;
            int odd = 0;
            while (a != 0)
            {
                tmp = a % 10;
                a /= 10;
                if (tmp % 2 != 0)
                {
                    odd++;
                }
            }
            return odd;
        } //9

        public static int GetTheReverseNumber(int a)
        {
            int tmp = 0;
            while (a > 0)
            {
                tmp = tmp * 10 + a % 10;
                a = a / 10;
            }
            return tmp;

        } //10

        public static int[] FindNumbersWithGreaterEvenSum(int n)
        {
            int integer, remainder, even, odd;
            int[] result = new int[n];
            int tmp = 0;
            for (int i = 1; i <= n; i++)
            {
                integer = i;
                even = odd = 0;
                while (integer != 0)
                {
                    remainder = integer % 10;
                    integer = integer / 10;

                    if (remainder % 2 == 0)
                    {
                        even = even + remainder;
                    }
                    else
                    {
                        odd = odd + remainder;
                    }
                }
                if (even > odd)
                {
                    result[tmp] = i;
                    tmp++;

                }

            }
            return result;

        } //11

        public static string CheckNumbersForSameDegits(int numb1, int numb2)
        {
            int tmp1;
            int secondNumber;
            int tmp2;
            numb1 = Math.Abs(numb1);
            numb2 = Math.Abs(numb2);
            bool isEqualNumber = false;
            string yes = "ДА";
            string no = "НЕТ";
            while (numb1 > 1)
            {
                tmp1 = numb1 % 10;
                secondNumber = numb2;
                while (secondNumber >= 1)
                {
                    tmp2 = secondNumber / 10;
                    if (tmp1 == tmp2)
                    {
                        isEqualNumber = true;
                    }

                    secondNumber = secondNumber / 10;
                }
                numb1 = numb1 / 10;
            }
            if (isEqualNumber)
            {
                return yes;
            }
            else
            {
                return no;
            }

        } //12
    }
}