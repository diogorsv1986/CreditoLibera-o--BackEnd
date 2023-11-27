using System;

namespace CreditProcessingAPI.Models
{
    public enum CreditType
    {
        Direto = 1,
        Consignado,
        PessoaJuridica,
        PessoaFisica,
        Imobiliario
    }

    public class CreditRequest
    {
        public decimal CreditAmount { get; set; }
        public CreditType Type { get; set; }
        public int Installments { get; set; }
        public DateTime FirstDueDate { get; set; }
    }
}
