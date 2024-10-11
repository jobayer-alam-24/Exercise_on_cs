namespace Exercise
{
    public static class Exercise71
    {
        public static void ConditionOnArray()
        {
            int[] arrayOfNums = {1, 2, 3, 5, 4, 2, 3, 4};
            object avg = arrayOfNums.Sum() / arrayOfNums.Length;

            if(avg is int)
            {
                Console.WriteLine($"It is a whole number.");
            }
            else
            {
                Console.WriteLine($"It is not a whole number");
            }

        }
    }
}