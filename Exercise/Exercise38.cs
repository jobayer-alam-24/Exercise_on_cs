namespace Exercise
{
    //Program to print the first two characters from a Given string
    public static class Exercise38
    {
        public static void FirstTwoChars()
        {
            string input;
            Console.WriteLine($"=====Taking Input=====");
            Console.Write($"Enter your name: ");
            input = Console.ReadLine();

            Console.WriteLine($"First Two Characters: {input.Substring(0, 2)}");
            
        }
    }
} 