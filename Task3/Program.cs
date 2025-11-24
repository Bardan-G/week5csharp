class Program
{
    static void Main(string[] args)
    {
        // ------- Printer Overloading Demo -------
        Printer printer = new Printer();

        printer.Print("Hello World");
        printer.Print(123);
        printer.Print("Repeat Message", 3);


        Console.WriteLine("\n--- Teacher Demonstration ---");

        // Nepali Teacher
        NepaliTeacher nepaliTeacher = new NepaliTeacher();
        nepaliTeacher.Name = "Mr. Sharma";

        Console.WriteLine($"Teacher Name: {nepaliTeacher.Name}");
        nepaliTeacher.Teaching();   
        nepaliTeacher.SalaryInfo(); 


        Console.WriteLine();

        // English Teacher
        EnglishTeacher englishTeacher = new EnglishTeacher();
        englishTeacher.Name = "Mrs. Brown";

        Console.WriteLine($"Teacher Name: {englishTeacher.Name}");
        englishTeacher.Teaching();  
        englishTeacher.SalaryInfo(); 

        Console.ReadLine();
    }
}