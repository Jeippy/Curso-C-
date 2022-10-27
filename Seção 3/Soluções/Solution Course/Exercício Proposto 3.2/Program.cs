using System;

namespace ExercicioProposto_3_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] entrada = Console.ReadLine().Split(' ');
            int x = int.Parse(entrada[0]);
            int y = int.Parse(entrada[1]);
            string saida = "";

            while (x != 0 && y != 0)
            {
                if (x > 0 && y > 0)
                {
                    Console.WriteLine("primeiro");
                } else if (x < 0 && y > 0)
                {
                    Console.WriteLine("segundo");
                } else if (x < 0)
                {
                    Console.WriteLine("terceiro");
                } else
                {
                    Console.WriteLine("quarto");
                }

                entrada = Console.ReadLine().Split(' ');
                x = int.Parse(entrada[0]);
                y = int.Parse(entrada[1]);
            }
        }
    }
}