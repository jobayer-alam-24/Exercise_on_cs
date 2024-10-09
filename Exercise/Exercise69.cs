using System;
namespace Exercise
{
    //Is only Lower or Upper
    public static class Exercise69
    {
        public static void IsOnlyLowerOrUpper()
        {
            string txt = "Lower";
            bool check = txt == txt.ToLower() || txt == txt.ToUpper();
            Console.WriteLine($"IS ONLY Lower OR Upper: {check}");
        }
    }
}