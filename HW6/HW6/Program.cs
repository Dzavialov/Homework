using System.Globalization;

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
                    SelectionSort(array);
                    break;
                case 3:
                    InsertionSort(array);
                    break;
            }
        }

        public static void BubbleSort(int[] array)
        {
            for (int m = 0; m < array.Length; m++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] < array[i + 1])
                    {
                        var k = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = k;
                    }
                }
            }

            PrintArray(array);
        }

        public static void SelectionSort(int[] array)
        {         
            for(int i = 0; i < array.Length - 1; i++)
            {
                var min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] < array[min])
                    {
                        min = j;
                    }
                }

                var k = array[min];
                array[min] = array[i];
                array[i] = k;
            }
            
            PrintArray(array);
        }

        public static void InsertionSort(int[] array)
        {
            int key;
            for(int i = 1; i < array.Length; i++)
            {
                key = array[i];
                int j = i - 1;
                while(j >= 0 && array[j] > key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
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