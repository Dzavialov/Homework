namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            byte a = 8;
            int b = 21324;
            double d = 17.95;

            Console.WriteLine($"Addition: a + b = {a + b}");
            Console.WriteLine($"Substraction: b - d = {b - d}");
            Console.WriteLine($"Multiplication: a * d = {a * d}");
            Console.WriteLine();
            Console.WriteLine("Enter x:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"-6*x^3+5*x^2-10*x+15 = {-6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15}");
            Console.WriteLine($"abs(x)*sin(x) = {Math.Abs(x) * Math.Sin(x)}");
            Console.WriteLine($"2*pi*x = {2*Math.PI*x}");
            
            Console.WriteLine("Enter y:");
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"max(x, y) = {Math.Max(x,y)}");
        }
    }
}