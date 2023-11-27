using System;

namespace CreditProcessingAPI.Services
{
    public class CreditService
    {
        public (bool approved, decimal totalWithInterest, decimal interestAmount) ProcessCreditRequest(Models.CreditRequest request)
        {
            // Validações
            if (request.CreditAmount > 1000000 || request.CreditAmount <= 0)
                return (false, 0, 0);

            if (request.Installments < 5 || request.Installments > 72)
                return (false, 0, 0);

            if (request.Type == Models.CreditType.PessoaJuridica && request.CreditAmount < 15000)
                return (false, 0, 0);

            var minDueDate = DateTime.Today.AddDays(15);
            var maxDueDate = DateTime.Today.AddDays(40);

            if (request.FirstDueDate < minDueDate || request.FirstDueDate > maxDueDate)
                return (false, 0, 0);

            // Cálculo de juros
            decimal interestRate = GetInterestRate(request.Type);
            decimal totalWithInterest = request.CreditAmount * (1 + interestRate);
            decimal interestAmount = totalWithInterest - request.CreditAmount;

            return (true, totalWithInterest, interestAmount);
        }

        private decimal GetInterestRate(Models.CreditType type)
        {
            switch (type)
            {
                case Models.CreditType.Direto:
                    return 0.02m;
                case Models.CreditType.Consignado:
                    return 0.01m;
                case Models.CreditType.PessoaJuridica:
                    return 0.05m;
                case Models.CreditType.PessoaFisica:
                    return 0.03m;
                case Models.CreditType.Imobiliario:
                    return 0.09m;
                default:
                    return 0;
            }
        }
    }
}
