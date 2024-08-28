namespace Exercise
{
    //Program to print string on certain condition
    public static class Exercise32
    {
        public static void PrintOnCertainCondition(string txt)
        {
            string fourChars = "";
            int len = txt.Length;

            if (txt.Length < 4)
            {
                Console.WriteLine("Less than four Characters: " + txt);
            }
            else
            {
                //Character numbers
                for (int i = 4; i >= 1; i--)
                {
                    fourChars += $"{txt[len - i]}";
                }
                Console.WriteLine($"Four Characters: {fourChars}");
            }

        }
    }
}