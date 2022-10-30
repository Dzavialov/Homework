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
        }

        static int MaxValue(int value1, int value2)
        {
            if(value1 > value2)
            {
                return value1;
            } else if (value1 < value2)
            {
                return value1 = value2;
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
    }
}