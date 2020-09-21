using System;
using System.Collections.Generic;

namespace BankStatementReader.Parser
{
    public class ReportDataSource
    {
        public int Id { get; }
        public string NumarReferintaCont { get; }
        public string ContIban { get; }
        public string NumarExtras { get; }
        public decimal SumaSoldInitial { get; }
        public decimal SumaSoldFinalRezervat { get; }
        public decimal? SumaSoldFinalDisponibil { get; }
        public string ValutaCont { get; }
        public DateTime DataExtras { get; }
        public List<Tranzactie> Tranzactii { get; }

        public ReportDataSource(Extras extras)
        {
            Id = extras.ExtrasId;
            NumarReferintaCont = extras.NumarReferinta;
            ContIban = extras.Iban;
            NumarExtras = extras.NrExtras;
            SumaSoldInitial = extras.SumaSoldInitial;
            SumaSoldFinalRezervat = extras.SumaSoldRezervat;
            SumaSoldFinalDisponibil = extras.SumaSoldFinalDisponibil;
            Tranzactii = extras.Tranzactii;
            DataExtras = extras.DataSoldInitial;
            ValutaCont = extras.ValutaSoldInitial;
        }
    }
}
