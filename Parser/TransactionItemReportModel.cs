using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankStatementReader.Parser
{
    public class TransactionItemReportModel
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

        public TransactionItemReportModel(Tranzactie tranzactie)
        {
            TranzactieId = tranzactie.TranzactieId;
            DataTranzactie = tranzactie.DataTranzactie;
            CodTranzactie = tranzactie.CodTranzactie;
            SumaTranzactie = tranzactie.SumaTranzactie;
            TipTranzactie = tranzactie.TipTranzactie;
            ReferintaClient = tranzactie.ReferintaClient;
            DetaliiTranzactie=tranzactie.DetaliiTranzactie;
            InformatiiPentruClient = tranzactie.InformatiiPentruClient;
            DataValutei = tranzactie.DataValutei;
        }
    }
}
