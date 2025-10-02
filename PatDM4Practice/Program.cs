using PatDM4Practice;

class Program
{
    static void Main()
    {
        Console.WriteLine("Choose a document type to create:");
        Console.WriteLine("1 - Report");
        Console.WriteLine("2 - Resume");
        Console.WriteLine("3 - Letter");
        Console.WriteLine("4 - Invoice");

        Console.Write("Enter your choice: ");
        string? choice = Console.ReadLine();

        if (choice is null)
        {
            Console.WriteLine("No input received. Exiting.");
            return;
        }

        DocumentCreator creator = choice switch
        {
            "1" => new ReportCreator(),
            "2" => new ResumeCreator(),
            "3" => new LetterCreator(),
            "4" => new InvoiceCreator(),
            _ => throw new InvalidOperationException("Invalid document type.")
        };

        Document document = creator.CreateDocument();
        document.Open();
    }
}

