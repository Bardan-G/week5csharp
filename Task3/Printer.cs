public class Printer
{
    // Print string
    public void Print(string message)
    {
        Console.WriteLine("Message: " + message);
    }

    // Print integer
    public void Print(int number)
    {
        Console.WriteLine("Number: " + number);
    }

    // Print message multiple times
    public void Print(string message, int count)
    {
        for (int i = 0; i < count; i++)
        {
            Console.WriteLine(message);
        }
    }
}