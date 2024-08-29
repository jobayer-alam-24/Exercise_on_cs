namespace Exercise
{
    //Program to check the range on two integers
    public static class Exercise36
    {
        public static void CheckOnIntegers()
        {
            int num1, num2;
            Console.WriteLine($"=========Taking Input========");
            Console.Write($"Enter the num 1 within (");
            PrintSign();
            num1 = int.Parse(Console.ReadLine());
            Console.Write($"Enter the num 2 within (");
            PrintSign();
            num2 = int.Parse(Console.ReadLine());

            if((num1 >= -10 && num1 <= 10) || (num2 >= -10 && num2 <= 10))
            {
                Console.WriteLine($"Exercise 36: True");
            }
            else
            {
                Console.WriteLine($"Exercise 36: False");
            }
        }
        private static void PrintSign()
        {
            for(int i = -10; i <= 10; i++)
            {
                Console.Write(i);
                if(i < 10)
                {
                    Console.Write($", ");
                }
            }
            Console.Write(") : ");
        }
    }
}