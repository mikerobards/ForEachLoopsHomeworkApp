
string input;
List<string> firstNames = new();

do
{
    Console.Write("Enter the first name (enter blank when finished): ");
    input = Console.ReadLine();
    if (input != "")
    {
        firstNames.Add(input);
    }
} while (input != "");

Console.WriteLine();

foreach (string name in firstNames)
{
    Console.WriteLine($"Hello {name}!");
}





