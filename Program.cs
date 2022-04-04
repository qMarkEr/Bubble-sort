namespace TestTask
{
 
    class App
    {

        // Ascending Sort
        public static int[] BubbleSort(int[] arr){
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }
        // Descending sort
        public static int[] BubbleSortReverse(int[] arr){
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr.Length - i - 1; j++)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
            return arr;
        }

        public static void Main(string[] args){

            int[] Array = {39, 78, 56, 36, 24, 25, 15, 15, 89, 71};

            // Printout of unsorted array
            System.Console.WriteLine("Unsorted: ");
            foreach (int item in Array)
                System.Console.Write($"{item} ");

            Array = BubbleSort(Array);  // Sort
            
            // Printout of sorted array
            System.Console.WriteLine("\n\nSorted (Ascended): ");
            foreach (int item in Array)
                System.Console.Write($"{item} ");

            Array = BubbleSortReverse(Array);  // Sort

            // Printout of sorted array
            System.Console.WriteLine("\n\nSorted (Ascended): ");
            foreach (int item in Array)
                System.Console.Write($"{item} ");
        }
    }
}