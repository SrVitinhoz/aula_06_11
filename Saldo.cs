public class Saldo
{
    private double saldo;

    public void SetSaldo(double s)

    {
        try
        {
            if (s >= 0)
            {
                saldo = s;
            }
            else
            {
                throw new Exception("O saldo não pode ser negativo"); // cria uma nova execeção
            }
        }
        catch (Exception ex)
        {

            throw new Exception(ex.Message); // executa as execeção 
        }
    }

    public double GetSaldo()
    {
        return saldo;
    }
}