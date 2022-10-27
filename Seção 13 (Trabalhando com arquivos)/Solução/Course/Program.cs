using System.IO;

namespace Course
{
    class Program
    {
        static void Main()
        {
            string sourcePath = @"C:\Users\xjoao\Desktop\Curso C#\Seção 13 (Trabalhando com arquivos)\file1.txt";
            string targetPath = @"C:\Users\xjoao\Desktop\Curso C#\Seção 13 (Trabalhando com arquivos)\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
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