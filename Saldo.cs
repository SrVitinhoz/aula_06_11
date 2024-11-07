public class Saldo
{
    private double saldo;

    public void SetSaldo(double s)

    {
        if (s >= 0)
        {
            saldo = s;
        }
        else
        {
            Console.WriteLine("Pode não ");
        }
    }
}