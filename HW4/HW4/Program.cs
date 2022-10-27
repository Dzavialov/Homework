namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Enter X:");
                string sX = Console.ReadLine();
                Console.WriteLine("Enter Y:");
                string sY = Console.ReadLine();

            //const int X = 10;
            //const int Y = 10;
            int X = -1;
            int Y = -1;
            int sum = 0;

            if (int.TryParse(sX, out X) & int.TryParse(sY, out Y))
            {
                if (X < Y)
                {
                    for (int i = X; i <= Y; i++)
                    {
                        sum += i;
                    }
                }
                else if (X > Y)
                {
                    for (int i = Y; i <= X; i++)
                    {
                        sum += i;
                    }
                }
                else
                {
                    sum = X;
                }
                Console.WriteLine(sum);
            }
            else
            {
                Console.WriteLine("Invalid input");
            }

            
        }
    }
}