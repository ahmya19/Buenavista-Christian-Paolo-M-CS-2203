
using System;

class Pentagon {
    private double side;
        
    public Pentagon()
    {
        side = 0;
    }
    public Pentagon(double side)
    {
        this.side = side;
    }
    public double GetPerimeter()
    {
        return 5 * side;
    }
    public double GetArea()
    {
        return (Math.Sqrt(5 * ( 5 + 2 * Math.Sqrt(5))) * side * side) / 4;
        
    }
    public void display(string name)
    {
        Console.WriteLine($"{name}");
        Console.WriteLine("-------------------------");
        Console.WriteLine($"Side Length: {side}");
        Console.WriteLine($"Perimeter: {GetPerimeter():F3}");
        Console.WriteLine($"Area: {GetArea():F3}");
    }
}
class Program 
{

    static void Main(){
        Pentagon p1 = new Pentagon();
        p1.display("Pentagon p1");
        Console.WriteLine("");
        Pentagon p2 = new Pentagon(5.0);
        p2.display("Pentagon p2");
    }
}

