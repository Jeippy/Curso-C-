namespace ExercicioFixacao3
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] lc = Console.ReadLine().Split(' ');

            int l = int.Parse(lc[0]);
            int c = int.Parse(lc[1]);

            int[,] mat = new int[l, c];

            for (int i = 0; i < l; i++)
            {
                string[] values = Console.ReadLine().Split(' ');
                for (int j = 0; j < c; j++)
                {
                    mat[i, j] = int.Parse(values[j]);
                }
            }

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < l; i++)
            {
                for (int j = 0; j < c; j++)
                {
                    if (mat[i, j] == n)
                    {
                        Console.WriteLine("Position " + i + "," + j);
                        if (j - 1 >= 0)
                        {
                            Console.WriteLine("Left: " + mat[i, j - 1]);
                        }
                        if (i - 1 >= 0)
                        {
                            Console.WriteLine("Up: " + mat[i - 1, j]);
                        }
                        if (j + 1 < c)
                        {
                            Console.WriteLine("Right: " + mat[i, j + 1]);
                        }
                        if (i + 1 < l)
                        {
                            Console.WriteLine("Down: " + mat[i + 1, j]);
                        }
                    }
                }
            }
        }
    }
}