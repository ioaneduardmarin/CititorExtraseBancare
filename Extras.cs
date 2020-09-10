using System;
using System.Collections.Generic;

namespace BankStatementReader
{
    public class Extras
    {
        public int ExtrasId { get; set; }
        //Informatii generale despre extras
        public string NumarReferinta { get; set; }
        public string Iban { get; set; }
        public string NrExtras { get; set; }
        public string NrSecventa { get; set; }
        //Informatii despre soldul initial
        public string CodSoldInitial { get; set; }
        public DateTime DataSoldInitial { get; set; }
        public string ValutaSoldInitial { get; set; }
        public decimal SumaSoldInitial { get; set; }
        public string? InformatiiPentruClientSoldInitial { get; set; }
        //Contine tranzactiile din exras
        public List<Tranzactie> Tranzactii = new List<Tranzactie>();
        //Informatii despre soldul final rezervat
        public string CodSoldFinalRezervat { get; set; }
        public DateTime DataSoldRezervat { get; set; }
        public string ValutaSoldRezervat { get; set; }
        public decimal SumaSoldRezervat { get; set; }
        public string? InformatiiPentruClientSoldRezervat { get; set; }
        //Informatii despre soldul final disponibil
        public string? CodSoldFinalDisponibil { get; set; }
        public DateTime? DataSoldFinalDisponibil { get; set; }
        public string? ValutaSoldFinalDisponibil { get; set; }
        public decimal? SumaSoldFinalDisponibil { get; set; }
        public string? InformatiiPentruClientSoldFinalDisponibil { get; set; }
        //Informatii despre soldul disponbil
        public string? CodSoldDisponibil { get; set; }
        public DateTime? DataSoldDisponibil { get; set; }
        public string? ValutaSoldDisponibil { get; set; }
        public decimal? SumaSoldDisponibil { get; set; }
        public string? InformatiiPentruClientSoldDisponibil { get; set; }
    }
}
