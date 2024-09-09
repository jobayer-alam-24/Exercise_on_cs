namespace Exercise
{
    //Program to multiply all Elements of array by length
    public static class Exercise65
    {
        public static void MultiplyByLength()
        {
            int num;
            Console.Write($"How many number do you want to provide: ");
            num = int.Parse(Console.ReadLine());
            int[] numbers = new int[num];


            for(int i = 0; i < num; i++)
            {
                Console.Write($"Enter num {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"=========Result========");
            foreach(int i in numbers)
            {
                Console.Write($"{i * num} ");
            }

        }
    }
}