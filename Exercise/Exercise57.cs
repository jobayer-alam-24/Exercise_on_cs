namespace Exercise
{
    //program to find the pair of adjacent elements that has the highest product of an array of integers.
    public static class Exercise57
    {
        public static void PairOfAdjacent()
        {
            int[] array = { 1, 2, 3, 4 };
            int len = array.Length;
            printSign(array, len);

            AndjacentHighest(array, len);
        }
        private static void printSign(int[] arr, int len)
        {
            Console.Write($"Array -> [");
            for (int i = 0; i < len; i++)
            {
                Console.Write(arr[i]);
                if (i < len - 1)
                {
                    Console.Write($", ");
                }
            }
            Console.WriteLine($"]");
        }
        private static void AndjacentHighest(int[] arr, int len)
        {
            int[] multiplied = new int[len - 1];
            int lastIndexBefore = len - 2, start = 0;

            for (int i = 0; i <= lastIndexBefore; i++)
            {
                multiplied[start] = arr[i] * arr[i + 1];
                start++;
            }
            int max = multiplied.Max();
            
            Console.Write($"{max}");
        }
    }
}