namespace Exercise
{
    //Program to check a number is 
    // * within 20 of 100 or 200

    /*
        ------------Details on the Problem------------
        * within 20 or 100 or 200 --means Range
        ! 100 - 20 = 80
        ! 100 + 20 = 120
        *so, num >= 80 && num <= 120 ----------1
        ! 200 - 20 = 180
        ! 200 + 20 = 220
        *so, num >= 180 && num <= 220 ----------2
    */
    public static class Exercise22
    {
        public static void CheckANumberIsWithin20Of100Or200(int num)
        {
            if ((num >= 80 && 120 >= num) || (num >= 180 && 220 >= num))
            {
                Console.WriteLine($"Problem 22: True");
            }
            else
            {
                Console.WriteLine($"Problem 22: False");
            }
        }
    }
}