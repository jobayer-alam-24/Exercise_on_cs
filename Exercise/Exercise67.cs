using System.ComponentModel.DataAnnotations.Schema;
namespace Exercise
{
    //Program to create a coded string from specified string
    public static class Exercise67
    {
        public static void CodedString()
        {
            string formattedString = "", decodedString = "";

            Console.WriteLine($"======Taking Input========");
            Console.Write($"Write something in English: ");
            string input = Console.ReadLine().ToUpper();
            
            //*Method Chaining: Each Method is called the Result of previous method
            formattedString = input.Replace('P', '9').Replace('T', '0').Replace('S', '1').Replace('H', '6').Replace('A', '8'); 
            Console.WriteLine("Encoded string: " + formattedString);

            Console.Write($"Enter the Encoded Value: ");
            string getFormatted = Console.ReadLine();
            decodedString = getFormatted.Replace('9', 'P').Replace('0', 'T').Replace('1', 'S').Replace('6', 'H').Replace('8', 'A');
            Console.WriteLine($"Decoded string: {decodedString.ToUpper()}");
        }
    }
}