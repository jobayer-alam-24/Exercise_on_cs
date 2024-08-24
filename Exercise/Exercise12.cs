namespace Exercise
{
    //Program to print a number from given input in a row with space and without space 2 times
    public static class Exercise12
    {
        public static void CertainOutputOnNumber()
        {
            int num;
            Console.WriteLine($"======Taking Input=====");
            Console.Write($"Enter an integer: ");
            num = int.Parse(Console.ReadLine());

            //row
            for (int i = 1; i <= 4; i++)
            {
                //col
                for (int j = 1; j <= 4; j++)
                {
                    if(i % 2 == 1)
                    {
                        Console.Write($"{num} ");
                    }
                    else{
                        Console.Write($"{num}");
                    }
                }
                Console.WriteLine();
            }

        }
    }
}