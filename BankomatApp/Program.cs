using System;

class Program
{
    const string CORRECT_PIN = "1234";

    static void Main(string[] args)
    {
        Console.WriteLine("🏧 Välkommen till Bankomat!");

        var customer = new Customer("Anna Svensson", "19900101-1234", CORRECT_PIN);

        Console.Write("Ange din 4-siffriga PIN-kod: ");
        string inputPin = Console.ReadLine();

        if (!customer.Authenticate(inputPin))
        {
            Console.WriteLine(" Fel PIN! Åtkomst nekad.");
            return;
        }

        Console.WriteLine($"✅ Välkommen, {customer.Person.Name}!");

        customer.Account.Deposit(5000m);

        while (true)
        {
            Console.WriteLine("\n--- 🏦 MENY ---");
            Console.WriteLine("1. Sätt in pengar");
            Console.WriteLine("2. Ta ut pengar");
            Console.WriteLine("3. Visa saldo");
            Console.WriteLine("4. Avsluta");
            Console.Write("Välj alternativ: ");

            string choice = Console.ReadLine();
            if (!int.TryParse(choice, out int option))
            {
                Console.WriteLine("Fel: Ange ett giltigt nummer.");
                continue;
            }

            switch (option)
            {
                case 1:
                    HandleDeposit(customer.Account);
                    break;
                case 2:
                    HandleWithdraw(customer.Account);
                    break;
                case 3:
                    Console.WriteLine($"💰 Ditt saldo: {customer.Account.Balance:C}");
                    break;
                case 4:
                    Console.WriteLine("Tack för ditt besök! Hej då! 👋");
                    return;
                default:
                    Console.WriteLine("Ogiltigt val.");
                    break;
            }
        }
    }

    static void HandleDeposit(BankAccount account)
    {
        Console.Write("Ange belopp att sätta in: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            account.Deposit(amount);
        }
        else
        {
            Console.WriteLine("Fel: Ogiltigt belopp.");
        }
    }

    static void HandleWithdraw(BankAccount account)
    {
        Console.Write("Ange belopp att ta ut: ");
        if (decimal.TryParse(Console.ReadLine(), out decimal amount))
        {
            account.Withdraw(amount);
        }
        else
        {
            Console.WriteLine("Fel: Ogiltigt belopp.");
        }
    }
}