using System;

public delegate void EventHandler();

class Program
{
    public static event EventHandler _show;

    static void Main()
    {
        // Add event handlers to Show event.
        _show += new EventHandler(Dog);
        _show += new EventHandler(Cat);
        _show += new EventHandler(Mouse);
        _show += new EventHandler(Mouse);

        // Invoke the event.
        _show.Invoke();
    }

    static void Cat()
    {
        Console.WriteLine("Cat");
        Console.ReadLine();
    }

    static void Dog()
    {
        Console.WriteLine("Dog");
        Console.ReadLine();
    }

    static void Mouse()
    {
        Console.WriteLine("Mouse");
        Console.ReadLine();
    }
}
