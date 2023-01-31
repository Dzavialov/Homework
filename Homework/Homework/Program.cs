using System.Text.Json;

namespace Homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many facts you want to see?");
            int count = int.Parse(Console.ReadLine());
            HttpClient client = new HttpClient();
            var responseTask = client.GetAsync("https://meowfacts.herokuapp.com/?count=" + count);
            responseTask.Wait();
            if(responseTask.IsCompleted)
            {
                var result = responseTask.Result;
                if(result.IsSuccessStatusCode)
                {
                    var fact = JsonSerializer.Deserialize<Fact>(result.Content.ReadAsStreamAsync().Result);
                    foreach(var x in fact.data)
                    {
                        Console.WriteLine("\n" + x);
                    }
                }
            }
        }
    }
}