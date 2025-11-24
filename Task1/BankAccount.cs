public class BankAccount
{
    // Private fields
    private string accountNumber;
    private double balance;

    // Public property (only get)
    public string AccountNumber
    {
        get { return accountNumber; }
    }

    // Public property with private set and validation (no zero or negative values)
    public double Balance
    {
        get { return balance; }
        private set
        {
            if (value > 0)
            {
                balance = value;
            }
            else
            {
                throw new Exception("Balance must be greater than 0.");
            }
        }
    }

    // Constructor to set account number and initial balance
    public BankAccount(string accNumber, double initialBalance)
    {
        accountNumber = accNumber;
        Balance = initialBalance; // uses property validation
    }

    // Deposit method
    public void Deposit(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Deposit amount must be positive.");
            return;
        }

        balance += amount;
        Console.WriteLine($"Deposited: {amount}");
    }

    // Withdraw method
    public void Withdraw(double amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Withdraw amount must be positive.");
            return;
        }

        if (amount > balance)
        {
            Console.WriteLine("Not enough balance to withdraw.");
            return;
        }

        balance -= amount;
        Console.WriteLine($"Withdrawn: {amount}");
    }
}
