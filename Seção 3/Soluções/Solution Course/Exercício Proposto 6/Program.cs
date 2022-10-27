using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] v = Console.ReadLine().Split(' ');

            double A = double.Parse(v[0], CultureInfo.InvariantCulture);
            double B = double.Parse(v[1], CultureInfo.InvariantCulture);
            double C = double.Parse(v[2], CultureInfo.InvariantCulture);
            double pi = 3.14159;

            double areaTri = A * C / 2;
            double areaCir = Math.Pow(C, 2) * pi;
            double areaTra = (A + B) * C / 2;
            double areaQua = Math.Pow(B, 2);
            double areaRet = A * B;

            Console.WriteLine($"TRIANGULO {areaTri.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"CIRCULO {areaCir.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"TRAPEZIO {areaTra.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"QUADRADO {areaQua.ToString("F3", CultureInfo.InvariantCulture)}");
            Console.WriteLine($"RETANGULO {areaRet.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}