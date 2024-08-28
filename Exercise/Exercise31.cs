namespace Exercise
{
    public static class Exercise31
    {
        public static void MultiplicationOfTwoArrays()
        {
            int[] array1 = {12, 32, -51, 42};
            int[] array2 = {11, 4, -51, -21};
            MultiOfTwo(array1, array2);
        }
        private static void MultiOfTwo(int[] arr1, int[] arr2)
        {
            int[] multi = new int[arr1.Length];
            int lastIndex = arr1.Length - 1;

            for(int i = 0; i <= lastIndex; i++)
            {
                multi[i] = arr1[i] * arr2[i];
            }

            
            Console.Write("Multiplication Array -> [");
            for(int i = 0; i <= lastIndex; i++)
            {
                Console.Write(multi[i]);
                if(i < lastIndex)
                {
                    Console.Write($", ");
                }
            }
            Console.Write("]");
        }
    }
}