using System.Globalization;
using Course.Entities;
using Course.Services;

namespace Course
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter contract data");
            Console.Write("Number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Date (dd/MM/yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
            Console.Write("Contract value: ");
            double totalValue = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Contract contract = new Contract(number, date, totalValue);

            Console.Write("Enter number of installments: ");
            int installmentNumber = int.Parse(Console.ReadLine());

            InstallmentService installmentService = new InstallmentService(installmentNumber, new Paypal());

            installmentService.ProcessInstalments(contract);

            Console.WriteLine(contract);
        }
    }
}