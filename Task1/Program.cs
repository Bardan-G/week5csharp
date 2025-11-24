class Program
{
    static void Main(string[] args)
    {
        // Create BankAccount object
        BankAccount account = new BankAccount("ACC12345", 1000);

        // Display account number
        Console.WriteLine("Account Number: " + account.AccountNumber);
        Console.WriteLine("Starting Balance: " + account.Balance);

        // Deposit money
        account.Deposit(500);

        // Withdraw money
        account.Withdraw(300);

        // Print remaining balance
        Console.WriteLine("Remaining Balance: " + account.Balance);

        Console.ReadLine();
    }
}