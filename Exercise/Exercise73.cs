namespace Exercise
{
    public static class Exercise73
    {
        public static void OddOrEvenLength()
        {
            string txt = "I love when you call me senorita";
            int len = txt.Length;

            if(len % 2 == 0)
            {
                Console.WriteLine($"Even Length: {len}");
            }
            else
            {
                Console.WriteLine($"Odd Array; {len}");
            }
        }
    }
}