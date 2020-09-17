using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public string ValutaCont { get; }
        public List<Tranzactie> Tranzactii { get; }= new List<Tranzactie>();

        public ReportDataSource(Extras extras)
        {
            Id = extras.ExtrasId;
            NumarReferintaCont = extras.NumarReferinta;
            ContIban = extras.Iban;
            NumarExtras = extras.NrExtras;
            SumaSoldInitial = extras.SumaSoldInitial;
            SumaSoldFinalRezervat = extras.SumaSoldRezervat;
            this.Tranzactii = extras.Tranzactii;
            ValutaCont = extras.ValutaSoldInitial;
        }
    }
}
