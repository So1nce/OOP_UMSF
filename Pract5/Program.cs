using System;
using System.Text;

abstract class RegularPolyhedron
{
    protected double EdgeLength;
    protected int EdgeCount;

    public RegularPolyhedron(double edgeLength, int edgeCount)
    {
        EdgeLength = edgeLength;
        EdgeCount = edgeCount;
    }

    public abstract double CalculateSurfaceArea();
    public abstract double CalculateVolume();
}

class Tetrahedron : RegularPolyhedron
{
    public Tetrahedron(double edgeLength) : base(edgeLength, 4)
    {
    }

    public override double CalculateSurfaceArea()
    {
        return Math.Sqrt(3) * EdgeLength * EdgeLength;
    }

    public override double CalculateVolume()
    {
        return Math.Sqrt(2) / 12 * EdgeLength * EdgeLength * EdgeLength;
    }
}

class Cube : RegularPolyhedron
{
    public Cube(double edgeLength) : base(edgeLength, 6)
    {
    }

    public override double CalculateSurfaceArea()
    {
        return 6 * EdgeLength * EdgeLength;
    }

    public override double CalculateVolume()
    {
        return EdgeLength * EdgeLength * EdgeLength;
    }
}

class Octahedron : RegularPolyhedron
{
    public Octahedron(double edgeLength) : base(edgeLength, 8)
    {
    }

    public override double CalculateSurfaceArea()
    {
        return 2 * Math.Sqrt(3) * EdgeLength * EdgeLength;
    }

    public override double CalculateVolume()
    {
        return Math.Sqrt(2) * EdgeLength * EdgeLength * EdgeLength / 3;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = Encoding.UTF8;

        Tetrahedron tetrahedron = new Tetrahedron(5);
        Console.WriteLine($"Площа поверхні тетраедра: {tetrahedron.CalculateSurfaceArea()}");
        Console.WriteLine($"Об'єм тетраедра: {tetrahedron.CalculateVolume()}");

        Cube cube = new Cube(4);
        Console.WriteLine($"Площа поверхні куба: {cube.CalculateSurfaceArea()}");
        Console.WriteLine($"Об'єм куба: {cube.CalculateVolume()}");

        Octahedron octahedron = new Octahedron(3);
        Console.WriteLine($"Площа поверхні октаедра: {octahedron.CalculateSurfaceArea()}");
        Console.WriteLine($"Об'єм октаедра:: {octahedron.CalculateVolume()}");

        Console.ReadLine();
    }
}