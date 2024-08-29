namespace Exercise
{
    //Program to check if "HP" appears at the second position in a string
    public static class Exercise37
    {
        public static void CheckHP()
        {
            string txt = "PHP Tutorial";
            if(txt[1] == 'H' && txt[2] == 'P')
            {
                string removed = txt.Remove(1, 2);
                Console.WriteLine($"Removed HP: {removed}");
            }
            else
            {
                Console.WriteLine($"Do not contains \"HP\"");
            }
        }
    }
}