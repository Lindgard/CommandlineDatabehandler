namespace CommandlineDatabehandler;

class Program
{
    static void Main(string[] args)
    {
        //* user input, output to user

        Console.WriteLine("do you wish to see the current list? (y/n)");
        string? choiceInput = Console.ReadLine();
        char? choice = string.IsNullOrEmpty(choiceInput) ? null : choiceInput[0];

    }
}
