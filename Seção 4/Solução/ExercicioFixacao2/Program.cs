using System.Globalization;

namespace ExercicioFixacao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario f1 = new Funcionario();

            Console.Write("Nome: ");
            f1.Nome = Console.ReadLine();
            Console.Write("Salário bruto: ");
            f1.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            f1.Imposto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine();
            Console.WriteLine($"Funcinário: {f1}");

            Console.WriteLine();
            Console.Write("Digite a porcentagem para aumentar o salário = ");
            double porcentagem = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture) / 100;
            f1.AumentarSalario(porcentagem);

            Console.WriteLine();
            Console.WriteLine($"Dados atualizados: {f1}");
        }
    }
}