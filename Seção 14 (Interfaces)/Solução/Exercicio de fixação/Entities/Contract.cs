using System.Collections.Generic;
using System.Globalization;

namespace Course.Entities
{
    class Contract
    {
        public int Number { get; set; }
        public DateTime Date { get; set; }
        public double TotalValue { get; set; }
        public List<Installment> Installments { get; set; }

        public Contract (int number, DateTime date, double totalValue)
        {
            Number = number;
            Date = date;
            TotalValue = totalValue;
            Installments = new List<Installment>();
        }

        public override string ToString()
        {
            string result = "Installments:";
            foreach(Installment installment in Installments)
            {
                result += "\n" + installment.DueDate.ToString("dd/MM/yyyy") + " - " + installment.Amount.ToString("F2", CultureInfo.InvariantCulture);
            }
            return result;
        }
    }
}
