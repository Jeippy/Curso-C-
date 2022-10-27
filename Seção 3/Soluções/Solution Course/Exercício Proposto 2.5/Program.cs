using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            int codigo = int.Parse(v[0]);
            int quant = int.Parse(v[1]);

            double resultado = 0.0;

            if (codigo == 1)
            {
                resultado = quant * 4.00;
            }
            else if (codigo == 2)
            {
                resultado = quant * 4.50;
            }
            else if (codigo == 3)
            {
                resultado = quant * 5.00;
            }
            else if (codigo == 4)
            {
                resultado = quant * 2.00;
            } else if (codigo == 5)
            {
                resultado = quant * 1.500;
            }
            Console.WriteLine($"Total: R$ {resultado.ToString("F2", CultureInfo.InvariantCulture)}");
        }
    }
}