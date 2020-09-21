using System;

namespace BankStatementReader
{
    public class Tranzactie
    {
        public int TranzactieId { get; set; }
        public DateTime DataTranzactie { get; set; }
        public string CodTranzactie { get; set; }
        public decimal SumaTranzactie { get; set; }
        public string TipTranzactie { get; set; }
        public string ReferintaClient { get; set; }
        public string DetaliiTranzactie { get; set; }
        public string InformatiiPentruClient { get; set; }
        public DateTime DataValutei { get; set; }
    }
}
