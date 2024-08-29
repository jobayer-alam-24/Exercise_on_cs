namespace Exercise
{
    //Program to find 'w' character between 1 and 3 times
    public static class Exercise41
    {
        public static void FindW()
        {
            string txt = "Meaw Runs";
            bool IsFound = false;

            for(int i = 1; i <= 3; i++)
            {
                if(txt[i] == 'w')
                {
                    IsFound = true;
                    break;
                }
                else
                {
                    IsFound = false;
                }
            }
            if(IsFound)
            {
                Console.WriteLine($"Found: w");
            }
            else
            {
                Console.WriteLine($"Not Found!");
            }
        } 
    }
}