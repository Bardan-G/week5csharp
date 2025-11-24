using Task3;

public class Teacher:teachersalaryinfo
{
    public string Name { get; set; }

    // Virtual means child classes can override it
    public virtual void Teaching()
    {
        Console.WriteLine("Teacher teaches in English");
    }

    // Sealed method (cannot be overridden)
    public sealed override void SalaryInfo()
    {
        Console.WriteLine("Salary is provided monthly.");
    }
}