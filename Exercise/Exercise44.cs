namespace Exercise
{
    //Program to print the odd Characters from string
    public static class Exercise44
    {
        public static void PrindtOddCharacters()
        {
            string txt = "Bangladesh";
            Console.WriteLine($"Default Text: {txt}");
            string oddChars = "";
            int len = txt.Length;

            for(int i = 1; i < txt.Length; i+=2)
            {
                oddChars += txt[i];
            }
            Console.WriteLine($"Odd Characters: {oddChars}");
        }
    }
}