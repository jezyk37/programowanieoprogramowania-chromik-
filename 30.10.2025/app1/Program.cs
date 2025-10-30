class Program
{
    private BankAccount bankAccount = new BankAccount();
    private double saldo;
    static void Main()
    {
        Program program = new Program();
        program.Wplac();
    }

    private void Wplac()
    {
        bankAccount.Wplac(100);
    }
    private void PobierzSaldo()
    {
        BankAccount bankAccount = new BankAccount();
    }
}

class BankAccount
{
    private double saldo = 0;

    
    public void Wplac(double kwota)
    {
        saldo += kwota;
         
    }
    public double PobierzSaldo() {
        return saldo;
    }
}