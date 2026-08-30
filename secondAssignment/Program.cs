using System;
class Program
{

    static void Main()
    {

        #region first Question
        int pages = 464;
        bool isAvailable = true;
        if (pages > 300 && isAvailable)
        {
            Console.WriteLine("You can borrow this book");
        }
        #endregion
        #region second Question
        string title = "Refactoring";
        switch (title)
        {
            case "Clean Code":
                Console.WriteLine("Great choice!");
                break;
            case "Refactoring":
                Console.WriteLine("Nice pick!");
                break;
            default:
                Console.WriteLine("Never heard of it");
                break;

        }

        #endregion
        #region third Question
        int pages2 = 464;
        string sizeLabel;
        sizeLabel = (pages2 > 300) ? "Long Book" : "Short Book";
        #endregion
        #region fourth Question
        string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
        for (int i = 0; i < books.Length; i++)
        {
            Console.WriteLine(i + 1 + "." + books[i]);

        }
        #endregion
        #region fifth Question
        int j = 0;
        while (j < books.Length)
        {
            Console.WriteLine(j + 1 + "." + books[j]);
            j++;
        }

        #endregion
        #region sixth Question
        int x = 0;
        do
        {
            Console.WriteLine("Checking book...");
            x++;
        } while (x < 3);

        #endregion
        #region seventh Question
        foreach (string book in books)
        {
            Console.WriteLine(book);
        }
        #endregion
        #region eighth Question
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == "Refactoring")
                break;

            Console.WriteLine(books[i]);
        }
        #endregion
        #region ninth Question
        for (int i = 0; i < books.Length; i++)
        {
            if (books[i] == "The Pragmatic Programmer")
                continue;

            Console.WriteLine(books[i]);
        }
        #endregion
        #region tenth Question
        void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
                return;

            Console.WriteLine(books[0]);
        }
        PrintFirstBook(books);
        #endregion

 
}
}