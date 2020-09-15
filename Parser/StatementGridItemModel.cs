namespace BankStatementReader
{
    public class StatementGridItemModel
    {
        //SGIM=StatementGridItemModel
        public int Id { get; }
        public string NumarReferintaCont { get; }
        public string ContIban { get; }
        public string NumarExtras { get; }
        public decimal SumaSoldInitial { get; }
        public decimal SumaSoldFinalRezervat { get; }

        public StatementGridItemModel(Extras extras)
        {
            Id = extras.ExtrasId;
            NumarReferintaCont = extras.NumarReferinta;
            ContIban = extras.Iban;
            NumarExtras = extras.NrExtras;
            SumaSoldInitial = extras.SumaSoldInitial;
            SumaSoldFinalRezervat = extras.SumaSoldRezervat;
        }
    }
}
