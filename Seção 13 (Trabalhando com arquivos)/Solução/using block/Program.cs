namespace Course
{
    class Program
    {
        static void Main()
        {
            string path = @"C:\Users\xjoao\Desktop\Curso C#\Seção 13 (Trabalhando com arquivos)\file1.txt";

            try
            {
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
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