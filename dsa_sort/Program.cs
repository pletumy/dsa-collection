using System.Text.Json.Serialization;

namespace dsa_buoi5
{
    public class Program
    {
        public static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }
        public static void SelectionSort(int[] arr) { 
            for (int i = 0; i < arr.Length - 1; i++)
            {
                int smallest = i;
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[smallest]) { 
                        smallest = j;
                    }
                }
                Swap(ref arr[smallest], ref arr[i]);
            }
        }

        public static void ExchangeSort(int[] arr) {
            int temp;
            for (int i = 0; i <= arr.Length - 1; i++) {
                for (int j = i+1; j < arr.Length - 2; j++)
                {
                    if (arr[i] > arr[j]) {
                        Swap(ref arr[i],ref arr[j]);
                    }
                }
            }
        }

        public static void InsertionSort(int[] arr) {
            int i = 1;
            while (i < arr.Length)
            {
                int j = i;
                while ((j > 0) && (arr[j-1] > arr[j])) {
                    Swap(ref arr[j],ref arr[j-1]);   
                    j = j-1;
                }
                i = i + 1;
            }
        }

        public static void BubbleSort(int[] arr) {
            int temp;
            for (int i = 0; i <= arr.Length - 2; i++)
            {
                for (int j = 0; j < arr.Length - 2; j++)
                {
                    if (arr[i] > arr[i+1])
                    {
                        Swap(ref arr[i + 1],ref arr[i]);
                    }
                }
            }
        }

        public static void QuickSort(int[] arr, int low, int high) {
            int p = 0;
            if (low < high) { 
                p = Partition(arr, low, high);  
            }
            if (p > 1) QuickSort(arr, low, high);
            if (p + 1 < high) QuickSort(arr, p + 1, high);
        }
        public static int Partition(int[] arr, int low, int high) {
            int pivot = arr[high];
            int i = low;
            for (int j = low; j < high; j++)
            {
                if (arr[j] < pivot) {
                    Swap(ref arr[j],ref arr[i]);
                    i = i + 1;
                }
            }
            Swap(ref arr[i], ref arr[high]);
            return i;
        }

        static void Main(string[] args)
        {
            int[] arr = new int[1000];
            int[] cpy = new int[1000];
            arr.CopyTo(cpy, 0);
            Random rnd = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0,10000);
            }

            //SelectionSort            
            Timing t1 = new Timing();
            int time = 0;
            for (int i = 0; i < 100; i++)
            {
                t1.startTime();
                SelectionSort(arr);
                t1.StopTime();
                time += t1.Result().Milliseconds;
            }
            Console.WriteLine($"Selection Sort: {time/100f} ms");

            //ExchangeSort
            time = 0;
            for (int i = 0; i < 100; i++)
            {
                t1.startTime();
                ExchangeSort(arr);
                t1.StopTime();
                time += t1.Result().Milliseconds;
            }
            Console.WriteLine($"Exchange Sort: {time / 100f} ms");

            //InsertionSort
            time = 0;
            for (int i = 0; i < 100; i++)
            {
                t1.startTime();
                InsertionSort(arr);
                t1.StopTime();
                time += t1.Result().Milliseconds;
            }
            Console.WriteLine($"Insertion Sort: {time / 100f} ms");

            //BubbleSort
            time = 0;
            for (int i = 0; i < 100; i++)
            {
                t1.startTime();
                BubbleSort(arr);
                t1.StopTime();
                time += t1.Result().Milliseconds;
            }
            Console.WriteLine($"Bubble Sort: {time / 100f} ms");

            //QuickSort
            time = 0;
            for (int i = 0; i < 100; i++)
            {
                t1.startTime();
                QuickSort(arr);
                t1.StopTime();
                time += t1.Result().Milliseconds;
            }
            Console.WriteLine($"Quick Sort: {time / 100f} ms");

        }
    }
}