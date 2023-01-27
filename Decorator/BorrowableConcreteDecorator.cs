using Decorator.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator;

public class BorrowableConcreteDecorator : Decorator
{
    protected readonly List<string> borrowers = new List<string>();
    public BorrowableConcreteDecorator(LibraryItem libraryItem) : base(libraryItem)
    {
    }
    public void BorrowItem(string name)
    {
        borrowers.Add(name);
        libraryItem.NumCopies--;
    }
    public void ReturnItem(string name)
    {
        borrowers.Remove(name);
        libraryItem.NumCopies++;
    }
    public override void Display()
    {
        base.Display();
        foreach (string borrower in borrowers)
        {
            Console.WriteLine(" borrower: " + borrower);
        }
    }
}
