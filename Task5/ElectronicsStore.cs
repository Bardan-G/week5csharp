public class ElectronicsStore
{
    private List<ElectronicDevice> devices = new List<ElectronicDevice>();

    public void AddDevice(ElectronicDevice device)
    {
        devices.Add(device);
    }

    public void RemoveDevice(ElectronicDevice device)
    {
        devices.Remove(device);
    }

    public void ShowAllDeviceDetails()
    {
        foreach (var device in devices)
        {
            device.ShowInfo();

            // Downcasting to call child-specific methods
            if (device is Laptop)
            {
                Laptop laptop = (Laptop)device;
                laptop.TurnOnBattery();
            }
            else if (device is Smartphone)
            {
                Smartphone phone = (Smartphone)device;
                phone.EnableCamera();
            }

            Console.WriteLine("-------------------------");
        }
    }
}