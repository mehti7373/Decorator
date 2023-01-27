using Decorator;
using Decorator.Components.LibraryItems;
/// <summary>
/// Decorator Design Pattern
/// </summary>
public class Program
{
    public static void Main(string[] args)
    {
        // Create book
        BookConcreteComponent book = new BookConcreteComponent("Worley", "Inside ASP.NET", 10);
        book.Display();
        // Create video
        VideoConcreteComponent video = new VideoConcreteComponent("Spielberg", "Jaws", 23, 92);
        video.Display();
        // Make video borrowable, then borrow and display
        Console.WriteLine("\nMaking video borrowable:");
        BorrowableConcreteDecorator borrowvideo = new BorrowableConcreteDecorator(video);
        borrowvideo.BorrowItem("Customer #1");
        borrowvideo.BorrowItem("Customer #2");
        borrowvideo.Display();
        // Wait for user
        Console.ReadKey();
    }
}