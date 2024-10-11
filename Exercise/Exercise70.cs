namespace Exercise
{
    public static class Exercise70
    {
        public static void isTwoSimilarConsecutive(string txt)
        {
            int lastBefore = txt.Length - 2;
            int check = 0;

            for(int i = 0; i < lastBefore; i++)
            {
                if(txt[i] == txt[i + 1])
                {
                    check++;
                    break;
                }
            }
            if(check > 0)
            {
                Console.WriteLine($"Has Two Similar Letters Consecutively: {txt}");
            }
            else
            {
               Console.WriteLine($"Hasn't Two Similar Letters Consecutively: {txt}"); 
            }
        }
    }
}