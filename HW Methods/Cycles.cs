namespace HW_Methods
{
    public class Cycles
    {
        public static int RaiseOneNumberToThePowerOfAnother(int a, int b) //1 
        {
            int result = 1;
            int module = Math.Abs(b);
            for (int i = 1; i <= module; i++)
            {
                if (b >= 0)
                {
                    result = result * a;
                }
                else
                {
                    result = result * -a;
                }
            }
            return result;
        }

        static public int[] GetDivisibleNumbers(int n)
        {   
            if (n < 1 || n > 1000)
            {
                throw new Exception("n cannot be less than 1 and more than 1000");
            }
            int[] temp = new int[1000/n];
            int b = 0;
            for (int i = 1; i <= 1000; i++)
            {
                if (i % n == 0)
                {
                    temp[b] = i;
                    b++;    
                }

            }
            return temp;
        } //2

        public static int GetTheAmountOfNumbers(int a) // 3
        {  
            int amount = 0;
            if (a < 1)
            {
                throw new Exception("a cannot be less than 1");
            }
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
            if (a < 1)
            {
                throw new Exception(" a must be positive integer");
            }
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
            if (n <= 0)
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
            if (a == 0 || b == 0)
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

        public static double FindCubicNumber(double n, double delta = 0.001)
        {
            double left = 0;
            double right = n;
            double tmp = 0;
            if (n <= 0)
            {
                throw new Exception("numb n cannot equal or be less than 0");
            }
            while (left * left * left + delta <= n || right * right * right - delta >= n)
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

        public static int FindTheAmountOfOddDigits(int a)
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
            if (a < 0)
            {
                throw new Exception("numb a cannot be less than 0");
            }
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
            int tmp = 0;
            int[] result = new int[n];
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
            Array.Resize(ref result, tmp);
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
            if (numb1 == 0 || numb2 == 0)
            {
                throw new Exception("Numbers can't equal 0");
            }
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