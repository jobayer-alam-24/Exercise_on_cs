namespace Exercise
{
    public static class Exercise77
    {
        public static void SumOfSquaresElementOfArray()
        {
            int[] arrayOfNums = {2, 4, 6, 8, 10};

            int sum = 0;
            foreach(int i in arrayOfNums)
            {
                sum += i * i;   
            }
            
            Console.Write($"Sum of Square of Numbers: {sum}");
        }
    }
}