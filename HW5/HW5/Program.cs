namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxValue(6,6));
            Console.WriteLine(MinValue(2,2));
            int sum;
            Console.WriteLine(TrySumIfOdd(11, 16, out sum));
            Console.WriteLine(MaxValue(10,1,2));
            Console.WriteLine(MinValue(10,20,0,50));
        }

        static int MaxValue(int value1, int value2)
        {
            if(value1 > value2)
            {
                return value1;
            } else if (value1 < value2)
            {
                return value2;
            } else return value1;
        }

        static int MinValue(int value1, int value2)
        {
            if (value1 < value2)
            {
                return value1;
            }
            else if (value1 > value2)
            {
                return value2;
            }
            else return value2;
        }

        static bool TrySumIfOdd(int value1, int value2, out int sum)
        {
            sum = 0;
            for (int i = value1 + 1; i < value2; i++)
            {
                sum += i;
            }

            if (sum % 2 == 0)
            {
                return false;
            }
            else return true;
        }

        static int MaxValue(int value1, int value2, int value3)
        {
            if (value1 > value2)
            {
                if (value1 > value3)
                {
                    return value1;
                }
                else return value3;
            }
            else if (value2 > value3)
            {
                return value2;
            }
            else return value3;
        }

        static int MinValue(int value1, int value2, int value3, int value4)
        {
            int min1;
            int min2;

            if (value1 < value2)
            {
                min1 = value1;
            }
            else min1 = value2;
            if(value3 < value4)
            {
                min2 = value3;
            } else min2 = value4;

            if (min1 < min2)
            {
                return min1;
            }
            else return min2;
        }
    }
}