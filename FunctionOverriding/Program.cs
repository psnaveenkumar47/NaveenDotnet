using System;

class Area
{
    public int SArea(int side)
    {
        return side*side;
    }
    public  double CArea(double radius)
    {
        return 3.15*radius*radius;
    }
    public  int RArea(int length,int breadth)
    {
        return length*breadth;
    }
    
} 
class MainClass
{
    static void Main()
    {
        

        int side;
        double radius ;
        int rectangle;
        Area area = new Area();
        side= area.SArea(10);
        radius=area.CArea(12.3);
        rectangle = area.RArea(12,23);
        Console.WriteLine($" Area of Square is: {side}\n Area of Circle is: {radius}\n Area of rectangle is: {rectangle}");
    }
    
    
}