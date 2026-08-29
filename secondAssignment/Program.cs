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


    }
}