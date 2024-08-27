namespace Exercise
{
    public static class Exercise26
    {
        public static void SumOf500PrimeNumbers()
        {   
            int counter = 0, sum = 0, start = 2;
            while(counter < 500)
            {
                if(IsPrime(start))
                {
                    sum += start;
                    counter++;
                }
                start++;
            }
            Console.WriteLine($"Sum of 500 prime numbers: {sum}");
        }
        public static bool IsPrime(int n)
        {
            int count = 0;
            if (n > 1)
            {
                for (int i = 2; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        count++;
                        break;
                    }
                }
                if(count > 0)
                {
                   return false; 
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}