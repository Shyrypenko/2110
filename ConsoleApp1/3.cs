using System;

public class Airplane
{
    public string Name { get; set; }
    public string Manufacturer { get; set; }
    public int YearOfProduction { get; set; }
    public string Type { get; set; }

    public Airplane() { }

    public Airplane(string name, string manufacturer, int yearOfProduction, string type)
    {
        Name = name;
        Manufacturer = manufacturer;
        YearOfProduction = yearOfProduction;
        Type = type;
    }

    public void InputData()
    {
        Console.Write("Name of plane: ");
        Name = Console.ReadLine();

        Console.Write("Name of manufacture: ");
        Manufacturer = Console.ReadLine();

        Console.Write("Yer of production: ");
        YearOfProduction = int.Parse(Console.ReadLine());

        Console.Write("Type of palne: ");
        Type = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"Name of plane: {Name}, Manufacture: {Manufacturer}, Year of production: {YearOfProduction}, Type: {Type}");
    }
}
