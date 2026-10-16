// Week 1 Task 1 - User input

Console.WriteLine("Enter your name: ");
string name = Console.ReadLine() ?? "";

Console.WriteLine("Enter your age: ");
string ageInput = Console.ReadLine() ?? "";

if (int.TryParse(ageInput, out int age) && age >= 0)
{
    int futureAge = age + 5;

    Console.WriteLine($"Hello, {name}!");
    Console.WriteLine($"In 5 years, you will be {futureAge} years old.");
}
else
{
    Console.WriteLine("Please enter a valid non-negative age.");
}

