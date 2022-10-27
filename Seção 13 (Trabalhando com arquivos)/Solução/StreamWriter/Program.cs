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
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))
                {
                    foreach(string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
                }
            }
            catch (IOException e)
            {
                Console.Write("An error occurred");
                Console.Write(e.Message);
            }
        }
    }
}