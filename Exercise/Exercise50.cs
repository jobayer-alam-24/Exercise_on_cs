namespace Exercise
{
    public static class Exercise50
    {
        public static void RotateAnArray()
        {
            int[] array = {1, 2, 8, 10, 14, 13};
            int len = array.Length;
            PrintWithSign(array, len);
            Rotate(array, len);
        }
        private static void PrintWithSign(int[] arr, int len)
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
        private static void Rotate(int[] arr, int len)
        {
            int[] reverse = new int[len];
            int start = 0;
            for(int i = len - 1; i >= 0; i--)
            {
                reverse[start] = arr[i];
                start++;
            }
            Console.Write($"Array Reverse -> [");
            for(int i = 0; i < len; i++)
            {
                Console.Write(reverse[i]);
                if(i < len - 1)
                {
                    Console.Write($", ");
                }
            }
            Console.WriteLine($"]");
        }
    }
}