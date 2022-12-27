namespace StackGeneric
{
    internal class Program
    {
        static void Main(string[] args)
        {
            GenericStack<int> gs1 = new GenericStack<int>();
            gs1.Push(50);
            gs1.Push(11);
            gs1.Push(8);
            gs1.Push(6);

            gs1.Pop();
            gs1.Pop();

            gs1.Push(1000);
            gs1.Clear();

            gs1.Push(500);
            gs1.Push(600);
            gs1.Push(800);
            gs1.Push(900);
            gs1.Push(1000);

            Console.WriteLine(gs1.Peek());
            Console.WriteLine(gs1.Count());
            Console.WriteLine();

            int[] intArr = new int[gs1.Count()];
            gs1.CopyTo(intArr);
            foreach(var x in intArr)
            {
                Console.WriteLine(x);
            }

            gs1.Clear();
            gs1.Push(123);
            Console.WriteLine(gs1.Peek());
            gs1.Pop();
        }
    }
}