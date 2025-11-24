class Program
{
    static void Main(string[] args)
    {
        // Create Car object
        Car car = new Car();
        car.Brand = "Toyota";
        car.Speed = 150;
        car.Seats = 5;

        // Create Motorcycle object
        Motorcycle bike = new Motorcycle();
        bike.Brand = "Yamaha";
        bike.Speed = 120;
        bike.HasBackSeat = true;

        // Calling base class methods
        car.Start();
        car.DisplayInfo();
        car.Stop();

        Console.WriteLine();

        bike.Start();
        bike.DisplayInfo();
        bike.Stop();

        Console.ReadLine();
    }
}