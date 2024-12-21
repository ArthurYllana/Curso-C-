namespace ContaBancaria
{
    public class Conta
    {
        public string Titular { get; set; }
        private double saldo;

        public void Deposito (double quantia)
        {
            saldo += quantia;
        }

        public double GetSaldo()
        {
            return saldo;
        }
    }
}