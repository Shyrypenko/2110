using System;

public class Employee
{
    public string FullName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string Phone { get; set; }
    public string WorkEmail { get; set; }
    public string Position { get; set; }
    public string JobDescription { get; set; }

    public Employee() { }

    public Employee(string fullName, DateTime dateOfBirth, string Phone, string workEmail, string position, string jobDescription)
    {
        FullName = fullName;
        DateOfBirth = dateOfBirth;
        Phone = Phone;
        WorkEmail = workEmail;
        Position = position;
        JobDescription = jobDescription;
    }

    public void InputData()
    {
        Console.Write("Enter fullname: ");
        FullName = Console.ReadLine();

        Console.Write("Enter birthday (YYYY-MM-DD): ");
        DateOfBirth = DateTime.Parse(Console.ReadLine());

        Console.Write("Enter phone number: ");
        Phone = Console.ReadLine();

        Console.Write("Email: ");
        WorkEmail = Console.ReadLine();

        Console.Write("Work: ");
        Position = Console.ReadLine();

        Console.Write("Job description: ");
        JobDescription = Console.ReadLine();
    }

    public void DisplayData()
    {
        Console.WriteLine($"Fullname: {FullName}, Birthday: {DateOfBirth:YYYY-MM-DD}, Phone: {Phone}, Email: {WorkEmail}");
        Console.WriteLine($"Work: {Position}, Job description: {JobDescription}");
    }
}
