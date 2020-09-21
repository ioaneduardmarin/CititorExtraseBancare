using System;
using System.Collections.Generic;

namespace BankStatementReader.Parser
{
    public class StatementReportDataSource
    {
        public int Id { get; set; }
        public string NumarReferintaCont { get; set; }
        public string ContIban { get; set; }
        public string NumarExtras { get; set; }
        public decimal SumaSoldInitial { get; set; }
        public decimal SumaSoldFinalRezervat { get; set; }
        public decimal? SumaSoldFinalDisponibil { get; set; }
        public string ValutaCont { get; set; }
        public DateTime DataExtras { get; set; }
        public List<TransactionItemReportModel> Tranzactii { get; set; }

        public StatementReportDataSource(Extras extras)
        {
            Id = extras.ExtrasId;
            NumarReferintaCont = extras.NumarReferinta;
            ContIban = extras.Iban;
            NumarExtras = extras.NrExtras;
            SumaSoldInitial = extras.SumaSoldInitial;
            SumaSoldFinalRezervat = extras.SumaSoldRezervat;
            SumaSoldFinalDisponibil = extras.SumaSoldFinalDisponibil;
            DataExtras = extras.DataSoldInitial;
            ValutaCont = extras.ValutaSoldInitial;
        }
    }
}
