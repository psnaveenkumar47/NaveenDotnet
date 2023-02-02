using System;
namespace ClassLibrary
{

    class Area
    {
        public int SArea(int side)
        {
            return side * side;
        }
        public double CArea(double radius)
        {
            return 3.15 * radius * radius;
        }
        public int RArea(int length, int breadth)
        {
            return length * breadth;
        }

    }
    
}