class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();   
            int SIZE = rnd.Next(20);
            int[] arr = new int[SIZE];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next();
            }
            
            SORT(arr);

        }
        
        static void SORT(int[] arr)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            for(int i = 0; i < arr.Length;i++)
            {
                if(arr[i] < min)
                {
                    min = arr[i];
                }
                else if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            Console.WriteLine("Min element = {0}", min);
            Console.WriteLine("Max element = {0}", max);
            BubbleSort(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("{0}{1}", arr[i], '\t');
            }
        }
        
        static void BubbleSort(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                for(int j = 0; j < arr.Length - 1; j++)
                {
                    if(arr[j] > arr[j + 1])
                    {
                        int temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
    }
}