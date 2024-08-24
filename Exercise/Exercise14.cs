namespace Exercise
{
    //Program to convert celsius to Kelvin and Fahrenheit
    public static class Exercise14
    {
        public static void TemperatureConverterFromCelsius(double cel)
        {
            double kelvin = cel + 273;
            double fahren = (cel * 9 / 5) + 32;
            Console.WriteLine($"Temperature: {kelvin}° Kelvin");
            Console.WriteLine($"Temperature: {fahren}° Fahrenheit");
        }
    }
}