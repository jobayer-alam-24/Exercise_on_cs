namespace Exercise
{
    //Program to find the multiplication of three numbers
    public static class Exercise06
    {
        public static void MultiplicationOfThreeNumbers()
        {
            int x, y, z;
            Console.WriteLine($"======Program to Get the Multiplication of Three Numbers===========");
            Console.Write($"Enter number - 1: ");
            x = int.Parse(Console.ReadLine());
            Console.Write($"Enter number - 2: ");
            y = int.Parse(Console.ReadLine());
            Console.Write($"Enter number - 3: ");
            z = int.Parse(Console.ReadLine());

            Console.WriteLine($"=========Result========");
            Console.WriteLine($"{x} X {y} X {z} = {x * y * z}");
        }
    }
}