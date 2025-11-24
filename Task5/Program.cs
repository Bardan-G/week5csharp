class Program
{
    static void Main(string[] args)
    {
        ElectronicsStore store = new ElectronicsStore();

        Laptop laptop = new Laptop("Dell", 120000);
        Smartphone phone = new Smartphone("Samsung", 80000);

        store.AddDevice(laptop);
        store.AddDevice(phone);

        store.ShowAllDeviceDetails();

        Console.ReadLine();
    }
}