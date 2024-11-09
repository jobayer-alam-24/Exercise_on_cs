namespace Exercise
{
    public static class Exercise82
    {
        public static void RemoveVowels()
        {
            Console.Write($"Enter a text: ");
            string txt = Console.ReadLine().ToLower();
            string removedVowels = new string(
                txt.Where()
            );
            
            Console.WriteLine($"Removed Vowel: {removedVowels}");
            /*I am NEW TO SHOW ON GIT PULL*/
            // I have changed you
            //Create new branch
        }
    }
}
