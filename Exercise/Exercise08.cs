namespace Exercise
{
    //Program to print Multiplication Table
    public static class Exercise08
    {
        public static void MultiplicationTable()
        {
            int x;
            Console.WriteLine($"========Taking input for Multiplication Table========");
            Console.Write($"Enter the number: ");
            x = int.Parse(Console.ReadLine());

            for(int i = 1; i <= 10; i++){
                Console.WriteLine($"{x} X {i} = {x * i}");
            }
        }
    }
}