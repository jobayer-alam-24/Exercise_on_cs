namespace Exercise
{
    //Count Specified character in a sentence
    public static class Exercise68
    {
        public static void CountSpecifiedChar(string sentence, char letter)
        {
            int count = 0;
            sentence = sentence.ToLower();
            foreach(char i in sentence)
            {
                if(i == letter)
                {
                    count++;
                }
            }
            Console.WriteLine($"{letter} in Sentence: {count}");
        }
    }
}