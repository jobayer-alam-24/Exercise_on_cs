namespace Exercise
{
    //Program to calculate the sum of all integer in a rectangular array except 0 and below 0
    public static class Exercise59
    {
        public static void RectangularMatrixSumExceptZeroandBelowZero()
        {
            int[,] matrix = {
                {0, 2, -3, 2},
                {0, -6, 0, 1},
                {4, 0, 3, 0}
            };
            int sum = 0;
            foreach(int i in matrix)
            {
                if(i > 0)
                {
                    sum += i;
                }
            }
            Console.WriteLine($"Suma: {sum}");

        }
    }
}