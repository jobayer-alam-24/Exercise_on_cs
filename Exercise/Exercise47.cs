namespace Exercise
{
    //Program to find the sumation of all elements in an array
    public static class Exercise47
    {
        public static void SumOfArray()
        {
            int[] array = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            PrintWithSign(array);
            PrintSum(array);
        }
        private static void PrintWithSign(int[] arr)
        {
            int len = arr.Length;
            Console.Write($"Data -> [");
            for(int i = 0; i < len; i++)
            {
                Console.Write(arr[i]);
                if(i < len - 1)
                {
                    Console.Write($", ");
                }
            }
            Console.WriteLine($"]");
        }
        private static void PrintSum(int[] arr)
        {
            int sum = 0;
            foreach(int i in arr)
            {
                sum += i;
            }
            Console.WriteLine($"Sum of All Elements: {sum}");
        }
    }
}