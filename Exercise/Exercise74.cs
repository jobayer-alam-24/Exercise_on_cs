namespace Exercise
{
    public static class Exercise74
    {
        public static void NthOfOddNumber()
        {
            //Formula = 2 * n - 1 (n number of ODD)
            Console.Write($"Enter the value of n for nth of ODD: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{n}th ODD Number is: {(2 * n) - 1}");
        }
    }
}