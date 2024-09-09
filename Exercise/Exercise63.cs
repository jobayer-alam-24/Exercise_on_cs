using System.Security.Cryptography;
using System.Reflection.Emit;
namespace Exercise
{
    //Program to check if a given number is present in an array of numbers.
    public static class Exercise63
    {
        public static void IsPresentNumberInArray()
        {
            int[] numbers = {1, 2, 3, 4, 5};

            Console.Write($"Enter the number you want to find: ");
            int num = int.Parse(Console.ReadLine());
            
            string messege = numbers.Contains(num) ? "Found." : "Not Found!";
            Console.WriteLine(messege);
           
            
        }
    }
}