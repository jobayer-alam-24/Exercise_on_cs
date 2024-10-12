using System.Collections;
using System.ComponentModel;
using System;
namespace Exercise
{
    public static class Exercise72
    {
        public static void AlphabeticalOrder(string txt)
        {
            // Convert string class to array = ToCharArray()
            char[] txtArray = txt.ToCharArray();
            Array.Sort(txtArray);
            Console.WriteLine(txtArray);
        }
    }
}