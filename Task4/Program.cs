class Program
{
    static void Main(string[] args)
    {
        // Car object
        Car car = new Car();
        car.Display();
        car.StartEngine();
        car.StopEngine();

        Console.WriteLine();

        // Bike object
        Bike bike = new Bike();
        bike.Display();
        bike.StartEngine();
        bike.StopEngine();

        Console.ReadLine();
    }
}