namespace HW6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number of elements:");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for(int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"Enter {i} element: ");
                array[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine();
            PrintArray(array);
            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Select the number of sorting algorithm:");
            Console.WriteLine("1 - Bubble Sort, 2 - Selection Sort, 3 - Insertion Sort");
            int number = int.Parse(Console.ReadLine());
            Sort(array, number);
        }

        public static void Sort(int[] array, int algorithm)
        {
            switch (algorithm)
            {
                case 1:
                    BubbleSort(array);
                    break;
                case 2:
                    //BinarySort(array);
                    break;
                case 3:
                    //CoolSort(array);
                    break;
                case 4:
                   // FastSort(array);
                    break;
                case 5:
                   // MemoryEfficentSort(array);
                    break;
            }
        }

        public static void BubbleSort(int[] array)
        {
            var k = 0;

            for (int m = 0; m < array.Length; m++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        k = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = k;
                    }
                }
            }

            PrintArray(array);
        }

        public static void PrintArray(int[] array)
        {
            foreach (int i in array)
            {
                Console.WriteLine(i);
            }
        }
    }
}