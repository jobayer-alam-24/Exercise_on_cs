namespace Exercise
{
    //Program to print certain outptu based on two Operations
    public static class Exercise10
    {
        public static void CertainOutput()
        {
            int x, y, z, result1, result2;
            Console.WriteLine($"==========Taking Input========");
            Console.Write($"Enter number 1: ");
            x = int.Parse(Console.ReadLine());
            Console.Write($"Enter number 2: ");
            y = int.Parse(Console.ReadLine());
            Console.Write($"Enter number 3: ");
            z = int.Parse(Console.ReadLine());
            result1 = (x + y) * z;
            result2 = (x * y) + (y * z);
            Console.WriteLine($"({x} + {y}).{z} = {result1}");
            Console.WriteLine($"{x}.{y} + {y}.{z} = {result2}");
        }
    }
}