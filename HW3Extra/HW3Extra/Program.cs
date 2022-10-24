namespace HW3Extra
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime newYear1 = new DateTime(2022, 01, 01);
            DateTime newYear2 = new DateTime(2023, 01, 01);

            Console.WriteLine($"{Math.Round((DateTime.Now - newYear1).TotalDays)} days passed from New Year");
            Console.WriteLine($"{Math.Round((newYear2 - DateTime.Now).TotalDays)} days left to New Year");
        }
    }
}