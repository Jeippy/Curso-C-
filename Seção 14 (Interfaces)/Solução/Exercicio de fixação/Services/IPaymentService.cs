namespace Course.Services
{
    interface IPaymentService
    {
        public DateTime DueDate(DateTime date, int installment);
        public double Amount(double value, int installment);
    }
}