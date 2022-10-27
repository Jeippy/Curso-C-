using System;

namespace ExercicioProposto_3_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int gasolina = 0;
            int alcool = 0;
            int diesel = 0;
            int escolha = 0;

            while ( escolha != 4)
            {
                escolha = int.Parse(Console.ReadLine());

                if (escolha == 1)
                {
                    alcool++;
                }
                else if (escolha == 2)
                {
                    gasolina++;
                }
                else if (escolha == 3)
                {
                    diesel++;
                }
            }

            Console.WriteLine("MUITO OBRIGADO");
            Console.WriteLine($"Alcool: {alcool}");
            Console.WriteLine($"Gasolina: {gasolina}");
            Console.WriteLine($"Diesel: {diesel}");

        }
    }
}