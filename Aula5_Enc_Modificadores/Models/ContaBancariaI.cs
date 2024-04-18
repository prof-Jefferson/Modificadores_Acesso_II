public class ContaBancariaI
{
    private double saldo; // Saldo é acessível apenas dentro da classe ContaBancaria

    public void Depositar(double quantia)
    {
        if (quantia > 0)
        {
            saldo += quantia;
        }
    }

    public void Sacar(double quantia)
    {
        if (quantia > 0 && saldo >= quantia)
        {
            saldo -= quantia;
        }
    }

    public double ObterSaldo()
    {
        return saldo;
    }
}
