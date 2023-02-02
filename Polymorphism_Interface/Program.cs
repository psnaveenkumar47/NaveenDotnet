interface IShape
{
    void Draw();
}
class Circle:IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Circle");
    }
}
class Square:IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Square");
    }
}
class Rectangle:IShape
{
    public void Draw()
    {
        Console.WriteLine("Drawing Rectangle");
    }
}
class MainClass
{
    static void Main()
    {
        IShape[] shapes = new IShape[3];
        shapes[0] = new Circle();
        shapes[1] = new Square();
        shapes[2] = new Rectangle();
        foreach(IShape s in shapes)
        {
            s.Draw();
        }
    }
}