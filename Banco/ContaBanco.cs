namespace Banco
{
    public class ContaBanco
    {
        public int Numero { get; private set; }
        public string Titular { get; set; }
        public double Saldo { get; private set; }

        public ContaBanco(int numero, string titular){
            Numero = numero;
            Titular = titular;
        }
        public ContaBanco(int numero, string titular, double depositoInicial): this(numero, titular){
            Depositar(depositoInicial)
        }

        public void Depositar(double quantia){
            Saldo += quantia;
        }

        public void Sacar(double quantia){
            Saldo -= quantia + 5.0;
        }

        public override string ToString(){
            return "Conta " + ", Titular: " + Titular + ", Saldo: " + Saldo.ToString("F2");
        }    
    }    
}
