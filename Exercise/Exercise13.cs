namespace Exercise
{
    //Program to print Series of number from input
    public static class Exercise13
    {
        public static void NumberSeriesFromOutput()
        {
            int num;
            Console.WriteLine($"======Taking input======");
            Console.Write($"Enter an integer: ");
            num = int.Parse(Console.ReadLine());

            //row
            for (int i = 1; i <= 5; i++)
            {
                if (i == 1 || i == 5)
                {
                    for (int j = 1; j <= 3; j++)
                    {
                        Console.Write(num);
                    }
                }
                else
                {
                    for (int j = 1; j <= 2; j++)
                    {
                        Console.Write(num + " ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}