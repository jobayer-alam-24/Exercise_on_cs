using System;
namespace Exercise
{
    public static class Exercise79
    {
        public static void ConvertAllArrayElementsToString()
        {
            object[] combinedArray = {25, "Anna", false, DateTime.Now, 112.22};

            Console.WriteLine($"Original Type: ");
            foreach(object single in combinedArray){
                Console.WriteLine($"Value-> {single} :: Type-> {single.GetType()}");
            }
            Console.WriteLine($"Converted to String: ");
            foreach(object single in combinedArray){
                Console.WriteLine($"Value-> {single} :: Type-> {single.ToString().GetType()}");
            }
        }
    }
}