namespace Exercise
{
    //Program to create a middle array from 3 arrays
    public static class Exercise52
    {
        public static void MiddleArray()
        {
            int[] array1 = {1, 2, 5};
            int[] array2 = {0, 3, 8};
            int[] array3 = {-1, 0, 2};
            int[] MiddleArray = {array1[1], array2[1], array3[1]};
            int len = array1.Length;
            PrintWithSign(array1, array2, array3, MiddleArray, len);
        }
        private static void PrintWithSign(int[] arr1, int[] arr2, int[] arr3, int[] middle, int len)
        {
            Console.Write($"Array 1 -> [");
            Common(len, arr1);
            Console.WriteLine($"]");
            Console.Write($"Array 2 -> [");
            Common(len, arr2);
            Console.WriteLine($"]");
            Console.Write($"Array 3 -> [");
            Common(len, arr3);
            Console.WriteLine($"]");
            Console.Write($"Middle Array -> [");
            Common(len, middle);
            Console.WriteLine($"]");
        }
        private static void Common(int len, int[] array)
        {
            for(int i = 0; i < len; i++)
            {
                Console.Write(array[i]);
                if(i < len - 1)
                {
                    Console.Write($", ");
                }
            }
        }
    }
}