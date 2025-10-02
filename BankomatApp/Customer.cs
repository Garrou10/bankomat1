public class Customer
{
    public Person Person { get; }
    public BankAccount Account { get; }
    private string pin;

    public Customer(string name, string personalNumber, string pin)
    {
        Person = new Person(name, personalNumber);
        Account = new BankAccount();
        this.pin = pin;
    }

    public bool Authenticate(string enteredPin)
    {
        return pin == enteredPin;
    }
}