using System;

public class City
{
    public string Name { get; set; }
    public string Country { get; set; }
    public int Population { get; set; }
    public string PhoneCode { get; set; }
    public string[] Districts { get; set; }

    public City() { }

    public City(string name, string country, int population, string phoneCode, string[] districts)
    {
        Name = name;
        Country = country;
        Population = population;
        PhoneCode = phoneCode;
        Districts = districts;
    }

    public void InputData()
    {
        Console.Write("Enter name of city: ");
        Name = Console.ReadLine();

        Console.Write("Enter name of country: ");
        Country = Console.ReadLine();

        Console.Write("Enter number of habitans: ");
        Population = int.Parse(Console.ReadLine());

        Console.Write("Enter phone number: ");
        PhoneCode = Console.ReadLine();

        Console.Write("Enter cities by coma: ");
        Districts = Console.ReadLine()?.Split(',');
    }

    public void DisplayData()
    {
        Console.WriteLine($"City: {Name}, Country: {Country}, Population: {Population}, Phone number: {PhoneCode}");
        Console.WriteLine("Districts: " + string.Join(", ", Districts));
    }
}
