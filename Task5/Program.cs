Console.WriteLine("Enter an integer:");
string input = Console.ReadLine() ?? "";
if (int.TryParse(input, out int number))
{
    if (number % 2 == 0)
    {
        Console.WriteLine($"{number} is an even number.");
    }
    else
    {
        Console.WriteLine($"{number} is an odd number.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter an integer.");
}