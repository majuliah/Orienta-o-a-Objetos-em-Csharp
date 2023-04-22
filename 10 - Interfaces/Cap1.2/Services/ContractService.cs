using System;
using entities;

namespace services
{
    public class ContractService
    {
        private IOnlinePaymentService _onlinePaymentService;

        public ContractService(IOnlinePaymentService onlinePaymentService)
        {
            _onlinePaymentService = onlinePaymentService;
        }

        public void ProcessingContracts(Contract contract, int months)
        {
            double basicQuota = contract.TotalValue / months;

            for (int month = 1; month <= months; month++)
            {
                DateTime date = contract.Date.AddMonths(month);
                double updatedQuota = basicQuota + _onlinePaymentService.Interest(basicQuota, month);
                double fullQuota = updatedQuota + _onlinePaymentService.PaymentFee(updatedQuota);
                contract.AddInstallment(new Installment(date, fullQuota));
            }
        }
    }
}