namespace Exercise
{
    //Program to find the longest word in a string
    public static class Exercise24
    {
        public static void FindLongestWord(string sentence)
        {
            //String to array - using Split(' ') method based on space
            string[] sentenceArray = sentence.Split(' ');

            int maxLength = 0;
            string longText = "";
            foreach(string text in sentenceArray){
                if(text.Length > maxLength)
                {
                    maxLength = text.Length;
                    longText = text;
                }
            }
            Console.WriteLine($"Longest Text: {longText}");
        }
    }
}