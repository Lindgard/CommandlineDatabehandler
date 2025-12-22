using System.Data;

namespace CommandlineDatabehandler;

class Program
{
    static void Main(string[] args)
    {
        //* user input-output

        FileHandler fileHandler = new FileHandler();

        fileHandler.ReadFileContent("datasett.json");

        Console.WriteLine("do you wish to see the current list? (y/n)");
        string? choiceInput = Console.ReadLine();
        char? choice = string.IsNullOrEmpty(choiceInput) ? null : choiceInput[0];
        bool seeList = choice == 'y' || choice == 'Y';

    }
}
