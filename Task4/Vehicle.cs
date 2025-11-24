public abstract class Vehicle
{
    // Abstract methods (must be implemented in child classes)
    public abstract void StartEngine();
    public abstract void StopEngine();

    // Concrete method
    public void Display()
    {
        Console.WriteLine("This is a vehicle");
    }
}