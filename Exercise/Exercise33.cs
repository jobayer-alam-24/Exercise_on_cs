namespace Exercise
{

    public static class Exercise33
    {
        public static void IsNumberMultipleOFThreeOrSeven()
        {
            int num;
            Console.WriteLine($"========Taking Input=======");
            Console.Write($"Enter an Integer: ");
            num = int.Parse(Console.ReadLine());

            if((num % 3 == 0) || (num % 7 == 0))
            {
                Console.WriteLine($"Multiple of 3 OR 7: True");
            }
            else
            {
                Console.WriteLine($"Not a Multiple of 3 OR 7: False");
            }
        }
    }
}