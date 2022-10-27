using System.Globalization;

namespace ExercicioFixacao1
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c1;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre o titular da conta: ");
            string nome = Console.ReadLine();

            Console.Write("Haverá depósito inicial (s/n)? ");
            char depositoInicialO = char.Parse(Console.ReadLine());

            if (depositoInicialO == 's' || depositoInicialO == 'S')
            {
                Console.Write("Entre o valor de depósito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                c1 = new Conta(numero, nome, depositoInicial);
            }
            else
            {
                c1 = new Conta(numero, nome);
            }

            Console.WriteLine();
            Console.WriteLine("Dados da conta:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para depósito: ");
            double deposito = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Depositar(deposito);
            Console.WriteLine("Dados da conta atualizados:");
            Console.WriteLine(c1);

            Console.WriteLine();
            Console.Write("Entre um valor para saque: ");
            double saque = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            c1.Sacar(saque);
            Console.WriteLine(c1);
        }
    }
}