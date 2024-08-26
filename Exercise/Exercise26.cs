namespace Exercise
{
    //Program to Print the sum of first 500 prime Numbers
    public static class Exercise26
    {
        public static void SumOfPrime()
        {
            
        }
        public static bool isPrime(int num)
        {
            int count = 0;
            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    count++;
                    break;
                }
            }
            if (count > 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }

}


