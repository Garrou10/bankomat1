public class BankAccount
{
    private decimal balance;

    public decimal Balance => balance;

    public void Deposit(decimal amount)
    {
        if (amount > 0)
            balance += amount;
        else
            Console.WriteLine("Fel: Belopp måste vara större än 0.");
    }

    public bool Withdraw(decimal amount)
    {
        if (amount <= 0)
        {
            Console.WriteLine("Fel: Belopp måste vara större än 0.");
            return false;
        }
        if (amount > balance)
        {
            Console.WriteLine("Fel: Otillräckligt saldo.");
            return false;
        }
        balance -= amount;
        return true;
    }
}