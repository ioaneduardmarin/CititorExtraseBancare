using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementReader
{
    public class TransactionGridItemModel
    {
        public int TranzactieId { get; set; }
        public DateTime DataTranzactie { get; set; }
        public string CodTranzactie { get; set; }
        public decimal SumaTranzactie { get; set; }
        public string TipTranzactie { get; set; }
        public string? InformatiiPentruClient { get; set; }
        public string? ReferintaClient { get; set; }

        public TransactionGridItemModel(Tranzactie tranzactie)
        {
            this.TranzactieId = tranzactie.TranzactieId;
            this.DataTranzactie = tranzactie.DataTranzactie;
            this.CodTranzactie = tranzactie.CodTranzactie;
            this.SumaTranzactie = tranzactie.SumaTranzactie;
            this.TipTranzactie = tranzactie.TipTranzactie;
            this.ReferintaClient = tranzactie.ReferintaClient;
            this.InformatiiPentruClient = tranzactie.InformatiiPentruClient;
        }
    }
}
