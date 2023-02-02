class FahrenheitCelsius
{
    static void Main()
    {
        double Celsius,Fahrenheit;
        Console.Write("Enter temperature in Fahrenheit :");
        Fahrenheit=Convert.ToDouble(Console.ReadLine());
        Celsius = (Fahrenheit - 32) * 5 / 9;
        Console.WriteLine($"Temperature in Fahrenheit is: {Fahrenheit}\nTemperature in Celsius is:{Celsius}");
    }
}