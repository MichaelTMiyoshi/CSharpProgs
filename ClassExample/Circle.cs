using System;
using System.Xml;

namespace ClassExample;

public class Circle
{
    // property (instance variables)
    private double radius;
    public double Radius
    {
        get { return radius; }
        set { radius = value; }
    }

    // constructors
    public Circle()
    {
        radius = 0;
    }

    public Circle(double radius)
    {
        this.radius = radius;
    }

    public Circle(Circle C)
    {
        radius = C.radius;
    }

    // methods
    public double Circumference()
    {
        return Math.PI * radius * 2.0;
    }

    public double Area()
    {
        return Math.PI * radius * radius;
    }

    // ToString
    public override string ToString()
    {
        String output = $"Radius:     {radius, 8:0.000}\n";
        output += String.Format("Perimeter:  {0,8:0.000}\n", Circumference());
        output += $"Area:       {Area(), 8:0.000}\n";
        return output;
    }
}
