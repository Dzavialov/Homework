using Vote.Service;

namespace VotingApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            VoteService.NewLoginInApplication();

            Console.ReadKey();
        }
    }
}