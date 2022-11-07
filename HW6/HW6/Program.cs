using System.Globalization;

namespace HW6
{

    public enum SortAlgorithmType
    {
        BubbleSort = 1,
        SelectionSort = 2,
        InsertionSort = 3
    }

    public enum OrderBy
    {
        Asc = 1,
        Desc = 2
    }
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
            Console.WriteLine("Asc - 1, Desc - 2");
            int order = int.Parse(Console.ReadLine());
            Sort(array, (SortAlgorithmType)number, (OrderBy)order);
        }

        public static void Sort(int[] array, SortAlgorithmType algorithm, OrderBy order)
        {
            switch (algorithm)
            {
                case SortAlgorithmType.BubbleSort:

                    if ((int)order == 1)
                    {
                        BubbleSortAsc(array);
                    }
                    else if ((int)order == 2)
                    {
                        BubbleSortDesc(array);
                    }  
                    break;
                case SortAlgorithmType.SelectionSort:
                    if ((int)order == 1)
                    {
                        SelectionSortAsc(array);
                    }
                    else if ((int)order == 2)
                    {
                        SelectionSortDesc(array);
                    }
                    break;
                case SortAlgorithmType.InsertionSort:
                    if ((int)order == 1)
                    {
                        InsertionSortAsc(array);
                    } else if((int)order == 2)
                    {
                        InsertionSortDesc(array);
                    }
                    break;
            }
        }

        public static void BubbleSortDesc(int[] array)
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

        public static void BubbleSortAsc(int[] array)
        {
            for (int m = 0; m < array.Length; m++)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        var k = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = k;
                    }
                }
            }

            PrintArray(array);
        }

        public static void SelectionSortDesc(int[] array)
        {         
            for(int i = 0; i < array.Length - 1; i++)
            {
                var min = i;
                for(int j = i + 1; j < array.Length; j++)
                {
                    if(array[j] > array[min])
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
        public static void SelectionSortAsc(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
            {
                var min = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[min])
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


        public static void InsertionSortDesc(int[] array)
        {
            int key;
            for (int i = 1; i < array.Length; i++)
            {
                key = array[i];
                int j = i - 1;
                while (j >= 0 && array[j] < key)
                {
                    array[j + 1] = array[j];
                    j--;
                }
                array[j + 1] = key;
            }

            PrintArray(array);
        }
        public static void InsertionSortAsc(int[] array)
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