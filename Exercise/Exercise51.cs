using System.Reflection.Emit;
using System.Reflection.Metadata;
using System.Buffers;
using System.Collections;
using System.ComponentModel;
using System;
namespace Exercise
{
    //Program to find the largest value between first and last element of an array
    public static class Exercise51
    {
        public static void LargestFirstAndLast()
        {
            int[] array = {55, 22, 33, 44, 5};
            int len = array.Length;
            int firstValue = array[0], lastvalue = array[len - 1];
            PrintWithSign(array, len);
            LargestFromFirstAndLast(firstValue, lastvalue);
        }
        private static void PrintWithSign(int[] array, int len)
        {
            Console.Write($"Array -> [");
            for(int i = 0; i < len; i++)
            {
                Console.Write(array
                [i]);
                if(i < len - 1)
                {
                    Console.Write($", ");
                }
            }
            Console.WriteLine($"]");
        }
        private static void LargestFromFirstAndLast(int n1, int n2)
        {
            if(n1 != n2)
            {
                int maximum = int.Max(n1, n2);
                Console.WriteLine($"Max: {maximum}");
            }
            else 
            {
                Console.WriteLine($"First {n1} == Last {n2}");
            }
        }
    }
}