public class BankAccount
{
    public int ID { get; set; }
    public decimal Balance { get; set; }

    /*
     * the propfull snippet yields this:
     * 
    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }
    */

    public void Deposit(decimal amount)
    {
        this.Balance += amount;
    }

    public void Withdraw(decimal amount)
    {
        this.Balance -= amount;
    }
}