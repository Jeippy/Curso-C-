namespace Course.Services
{
    class Paypal : IPaymentService
    {
        public DateTime DueDate (DateTime date, int installment)
        {
            return date.AddMonths(installment);
        }

        public double Amount (double value, int installmlent)
        {
            return (value * (1 + installmlent * 0.01)) * 1.02;
        }
    }
}
