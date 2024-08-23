namespace Exercise
{
    //Program to find sum, sub, multi, divide and remainder of two Integers
    public static class Exercise07
    {
        public static void SumSubMultiRemainderOfTwoNumbers()
        {
            int x, y;
            Console.WriteLine($"------------Taking Input---------");
            Console.Write($"Enter number - 1: ");
            x = int.Parse(Console.ReadLine());
            Console.Write($"Enter number - 2: ");
            y = int.Parse(Console.ReadLine());
            Console.WriteLine($"---------Result--------");
            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
            Console.WriteLine($"{x} x {y} = {x * y}");
            Console.WriteLine($"{x} ÷ {y} = {x / y}");
            Console.WriteLine($"{x} modulo {y} = {x % y}");
        }
    }
}