using System.Globalization;

namespace ExercicioFixacao1
{
    class Conta
    {
        public int Numero { get; private set; }
        public string Nome { get; set; }
        public double Valor { get; private set; }

        public Conta(int numero, string nome)
        {
            Numero = numero;
            Nome = nome;
        }

        public Conta(int numero, string nome, double depositoInicial) : this(numero, nome)
        {
            Depositar(depositoInicial);
        }
        public void Depositar(double deposito)
        {
            Valor += deposito;
        }
        public void Sacar(double saque)
        {
            Valor -= saque + 5;
        }
        public override string ToString()
        {
            return $"Conta {Numero}, Titular: {Nome}, Saldo: $ {Valor.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
