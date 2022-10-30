namespace HW5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(MaxValue(6,6));
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
    }
}