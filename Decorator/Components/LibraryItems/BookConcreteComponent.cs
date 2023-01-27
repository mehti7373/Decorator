using Decorator.Abstract;

namespace Decorator.Components.LibraryItems;

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class BookConcreteComponent : LibraryItem
{
    private string author;
    private string title;
    // Constructor
    public BookConcreteComponent(string author, string title, int numCopies)
    {
        this.author = author;
        this.title = title;

        base.NumCopies = numCopies;
    }
    public override void Display()
    {
        Console.WriteLine("\nBook ------ ");
        Console.WriteLine(" Author: {0}", author);
        Console.WriteLine(" Title: {0}", title);
        Console.WriteLine(" # Copies: {0}", NumCopies);
    }
}
