namespace Exercise
{
    // program to check two given numbers where one is less than 100 and the other is greater than 200.
    public static class Exercise35
    {
        public static void CheckOnNumber()
        {
            int num1, num2;
            Console.WriteLine($"=======Taking Input======");
            Console.Write($"Enter 1: ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter 2: ");
            num2 = int.Parse(Console.ReadLine());

            if ((num1 < 100) && (num2 > 200))
            {
                Console.WriteLine($"Exercise35: True");
            }
            else
            {
                Console.WriteLine($"Exercise35: False");
            }
        }
    }
}