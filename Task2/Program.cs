Console.WriteLine("Enter your age: ");
string input = Console.ReadLine() ?? "";

if (int.TryParse(input, out int age))
{
    if (age < 0 || age >= 110)
    {
        Console.WriteLine("Invalid age. Enter an age from 0 to 109.");
    }
    else if (age < 13)
    {
        Console.WriteLine("You are a child.");
    }
    else if (age >= 13 && age <= 19)
    {
        Console.WriteLine("You are a teenager.");
    }
    else
    {
        Console.WriteLine("You are an adult.");
    }
}
else
{
    Console.WriteLine("Invalid input. Please enter a whole number.");
}
