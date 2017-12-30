using System;


class GeometryCalculator
{
    static void Main(string[] args)
    {
        string figure = Console.ReadLine().ToLower();
        decimal calculatedArea = 0m;
        calculatedArea = CalaculateArea(figure, calculatedArea);
        Console.WriteLine($"{calculatedArea:f2}");

    }

    private static decimal CalaculateArea(string figure, decimal calculatedArea)
    {
        if (figure == "triangle")
        {
            calculatedArea =
                CalculatTriangle();

        }
        else if (figure == "square")
        {
            calculatedArea = CalculateSquare();
        }
        else if (figure == "circle")
        {
            calculatedArea = CalculateCircle();
        }
        else if (figure == "rectangle")
        {
            calculatedArea = CalculateRectangle();

        }

        return calculatedArea;
    }

    private static decimal CalculateRectangle()
    {
        decimal side = decimal.Parse(Console.ReadLine());
        decimal side2 = decimal.Parse(Console.ReadLine());
        return side * side2;

    }

    private static decimal CalculateCircle()
    {
        decimal radius = decimal.Parse(Console.ReadLine());
        return (decimal)Math.PI * radius * radius;

    }

    private static decimal CalculateSquare()
    {
        decimal side = decimal.Parse(Console.ReadLine());
        return side * side;

    }

    private static decimal CalculatTriangle()
    {
        decimal side = decimal.Parse(Console.ReadLine());
        decimal height = decimal.Parse(Console.ReadLine());
        return (side * height) / 2;
    }
}
