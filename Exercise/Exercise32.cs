namespace Exercise
{
    //Program to print four copies of last four characters
    public static class Exercise32
    {
        public static void PrintOnCertainCondition(string txt)
        {
            string fourChars = "";
            int len = txt.Length;
            if(len < 4)
            {
                Console.WriteLine($"Less than Four Chars: {txt}");
            }
            else
            {
                for(int i = 4; i >= 1; i--)
                {
                    fourChars += txt[len - i];
                }
                Console.Write($"Four Characters: ");
                for(int i = 1; i <= 4; i++)
                {
                    Console.Write(fourChars);
                }
            }
        }
    }
}