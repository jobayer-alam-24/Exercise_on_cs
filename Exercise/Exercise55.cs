namespace Exercise
{
    //Program to find the pair of adjacent | their product and the largest one.

    /*
        *[1, 2, 3, 4]
        ? 1 * 2 = 2
        ? 2 * 3 = 6
        ? 3 * 4 = 12
        !From the largest one
        !Formula: 0 <= lastIndex - 2 (0 theke last er age/soman porjonto)
    */
    public static class Exercise55
    {
        public static void ProductOfPairAdjacentFromLargestOne()
        {
           int[] mainArray = {1, 2, 3, 4, 5, 6, 7};
           int len = mainArray.Length;
           PrintArray(mainArray, len);
           LargestProductFromAdjacentMultiplication(mainArray, len);
        }
        private static void LargestProductFromAdjacentMultiplication(int[] arr, int len)
        {
            int[] multiplied = new int[len - 1];
            int start = 0;
            for(int i = 0; i <= len - 2; i++)
            {
                multiplied[start] = arr[i] * arr[i + 1];
                start++;
            }
            
            PrintArray(multiplied, multiplied.Length);
            Console.WriteLine($"Maximum: {multiplied.Max()}");
        }
        private static void PrintArray(int[] arr, int len)
        {
            Console.Write($"Array -> [");
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
    }
}