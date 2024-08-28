namespace Exercise
{
    public static class Exercise27
    {
        public static void SumOfIntegersDigit(int number)
        {
            int rem, divide, sum = 0;
            while (true)
            {
                rem = number % 10;
                sum += rem;
                divide = number / 10;
                if(divide == 0) break;
                number = divide;
            }
            Console.WriteLine($"Sum: {sum}");
        }
    }
}