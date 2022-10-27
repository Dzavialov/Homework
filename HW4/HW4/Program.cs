namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int X = 10;
            const int Y = 10;
            int sum = 0;

            if(X < Y)
            {
                for(int i = X; i <= Y; i++)
                {
                    sum += i;
                }
            } else if (X > Y)
            {
                for(int i = Y; i <= X; i++)
                {
                    sum += i;
                }
            } else
            {
                sum = X;
            }

            Console.WriteLine(sum);
        }
    }
}