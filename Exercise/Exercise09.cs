namespace Exercise
{
    //Program to find the average of Four numbers
    public static class Exercise09
    {
        public static void AverageOfFourNumbers()
        {
            int x, y, z, p;
            double average;
            Console.WriteLine($"==========Taking Input====");
            Console.Write($"Enter number 1: ");
            x = int.Parse(Console.ReadLine());
            Console.Write($"Enter number 2: ");
            y = int.Parse(Console.ReadLine());
            Console.Write($"Enter number 3: ");
            z = int.Parse(Console.ReadLine());
            Console.Write($"Enter number 4: ");
            p = int.Parse(Console.ReadLine());
            Console.WriteLine($"=====Result====");
            average = (double)(x + y + z + p) / 4;
            Console.WriteLine($"Average: {average}");
        }
    }
}