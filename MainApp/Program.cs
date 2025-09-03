List<string> name_list = [];

Console.WriteLine("Hej och Välkommen: ");

string answer = " ";

do
{
    Console.Write("Ange ett namn: ");

    string input_name = Console.ReadLine()!;

    if (!string.IsNullOrEmpty(input_name))
    {
        name_list.Add(input_name);
    }
    Console.Clear();

    Console.Write("Vill du ange ett nytt namn? (j/n): ");
    answer = Console.ReadLine()!;
}
while (answer == "j");


Console.Clear();

Console.WriteLine("*** NAMNLISTA ***");

foreach (string name in name_list)
{
    Console.WriteLine(name);
}

Console.ReadKey();