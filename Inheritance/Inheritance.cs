using System;
class wheels
{
    public int carwheel;
    internal void carwheels(int number)
    {

        this.carwheel = number;
        Console.WriteLine($"car has {carwheel}");
    }

   
}
class Vehicles:wheels
{
    wheels w=new Vehicles();
    public void car()
    {
        w.carwheels(4);
       
    }
}
class MainClass
{
    static void Main()
    {
        wheels wheels = new wheels();
        Vehicles vehicles = new Vehicles(); 
        vehicles.car();

    }
}