using Course.Entities;

namespace Course.Services
{
    class InstallmentService
    {
        public int InstallmentNumber { get; set; }
        private IPaymentService _paymentService;

        public InstallmentService(int installmentNumber, IPaymentService paymentService)
        {
            InstallmentNumber = installmentNumber;
            _paymentService = paymentService;
        }

        public void ProcessInstalments(Contract contract)
        {
            double InstallmentValue = contract.TotalValue / InstallmentNumber;
            for (int i = 1; i <= InstallmentNumber; i++)
            {
                double amount = _paymentService.Amount(InstallmentValue, i);
                DateTime dueDate = _paymentService.DueDate(contract.Date, i);
                Installment installment = new Installment(dueDate, amount);

                contract.Installments.Add(installment);
            }
        }
    }
}
