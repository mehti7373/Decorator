using Decorator.Abstract;

namespace Decorator.Components.LibraryItems;

/// <summary>
/// The 'ConcreteComponent' class
/// </summary>
public class VideoConcreteComponent : LibraryItem
{
    private string director;
    private string title;
    private int playTime;

    // Constructor
    public VideoConcreteComponent(string director, string title, int numCopies, int playTime)
    {
        this.director = director;
        this.title = title;
        this.playTime = playTime;

        base.NumCopies = numCopies;
    }
    public override void Display()
    {
        Console.WriteLine("\nVideo ----- ");
        Console.WriteLine(" Director: {0}", director);
        Console.WriteLine(" Title: {0}", title);
        Console.WriteLine(" # Copies: {0}", NumCopies);
        Console.WriteLine(" Playtime: {0}\n", playTime);
    }
}
