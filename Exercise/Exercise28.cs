namespace Exercise
{
    //Program to reverse the words of a sentence
    public static class Exercise28
    {
        public static void ReverseAllWords(string word)
        {
            string[] textToArray = word.Split(' ');
            int lastIndex = textToArray.Length - 1;

            for(int i = lastIndex; i >= 0; i--)  
            {
                Console.Write(textToArray[i] + " ");
            } 
        }
    }
    
}