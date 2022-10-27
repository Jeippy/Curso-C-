using Course.Entities;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter file full path: ");
            string sourcePath = Console.ReadLine();

            string DirectoryPath = Path.GetDirectoryName(sourcePath);
            Directory.CreateDirectory(DirectoryPath + @"\out");
            string targetPath = DirectoryPath + @"\out\summary.txt";

            Product product;
            string[] lines;
            try
            {
                lines = File.ReadAllLines(sourcePath);
                using (StreamWriter sw = File.CreateText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        string[] fields = line.Split(";");
                        product = new Product(fields[0], double.Parse(fields[1], CultureInfo.InvariantCulture), int.Parse(fields[2]));
                        sw.WriteLine(product);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}