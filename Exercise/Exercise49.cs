using System.Runtime.InteropServices;
using System;
namespace Exercise
{
    //Program to find the equality of first or last elements of two arrays
    public static class Exercise49
    {
        public static void FirstAndLastElementIsEqualInTwoArrays()
        {
            int[] array1 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int[] array2 = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 2};
            int len = array1.Length;
            int len2 = array2.Length;
            PrintWithSign(array1, array2, len);
            IsEqual(array1, array2, len, len2);
        }
        private static void PrintWithSign(int[] arr1, int[] arr2, int len)
        {
            Console.Write($"Array 1 -> [");
            for(int i = 0; i < len; i++)
            {
                Console.Write(arr1[i]);
                if(i < len - 1)
                {
                    Console.Write($", ");
                }
            }
            Console.WriteLine($"]");
            Console.Write($"Array 2 -> [");
            for(int i = 0; i < len; i++)
            {
                Console.Write(arr2[i]);
                if(i < len - 1)
                {
                    Console.Write($", ");
                }
            }
            Console.WriteLine($"]");
        }
        private static void IsEqual(int[] arr1, int[] arr2, int len1, int len2)
        {
            if(len1 > 1 && len2 > 1)
            {
                if((arr1[0] == arr2[0]) || (arr1[len1 - 1] == arr2[len1 - 1]))
                {
                    Console.WriteLine($"Exercise 49: POSITIVE (First or Last Elements are Equal)");
                }
                else
                {
                    Console.WriteLine($"Exercise 49: NEGATIVE (First or last elements are not equal)");
                }
            }
            else
            {
                Console.WriteLine($"The length of two arrays are 1");
            }
        }
    }
}