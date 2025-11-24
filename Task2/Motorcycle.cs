public class Motorcycle : Vehicle
{
    public bool HasBackSeat { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Motorcycle Brand: {Brand}, Speed: {Speed} km/h, Back Seat: {HasBackSeat}");
    }
}