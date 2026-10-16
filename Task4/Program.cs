Console.WriteLine("Enter year:");
string input = Console.ReadLine() ?? "";
if (int.TryParse(input, out int year))
{
    if (year <= 0)
    {
        Console.WriteLine("Invalid year. Please enter a positive year.");
    }
    else if (year % 400 == 0)
    {
        Console.WriteLine($"{year} is a leap year.");
    }
    else if (year % 100 == 0)
    {
        Console.WriteLine($"{year} is not a leap year.");
    }
    else if (year % 4 == 0)
    {
        Console.WriteLine($"{year} is a leap year.");
    }
    else
    {
        Console.WriteLine($"{year} is not a leap year.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a whole year.");
}
