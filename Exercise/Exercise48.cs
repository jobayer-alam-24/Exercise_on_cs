using System;
namespace Exercise
{
    //Program to check the first and last element of an array
    public static class Exercise48
    {
        public static void FirstAndLastElementIsEqual()
        {
            int[] array = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int len = array.Length;
            PrintArrayWithSign(array, len);
            IsEqual(array, len);
        }
        private static void PrintArrayWithSign(int[] arr, int len)

        {
            Console.Write($"Array 1 -> [");
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

        private static void IsEqual(int[] arr, int len)
        {
            if(len > 1)
            {
                if(arr[0] == arr[len - 1])
                {
                    Console.WriteLine($"First Element == Last Element: {arr[0]} == {arr[len - 1]}");
                }
                else
                {
                    Console.WriteLine($"Not Equal!");
                }
            }
            else
            {
                Console.WriteLine($"Found only the First Element in the array.");
            }
        }
    }
}