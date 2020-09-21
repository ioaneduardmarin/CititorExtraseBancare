using System;
using System.Collections.Generic;
using System.Linq;

namespace BankStatementReader
{
    public class ExtrasParser : IExtrasParser
    {
        Extras _extras;
        private int _lastProcessedLineIndex;
        private int _extrasId = 0;
        private int _tranzactieId = 0;

        public Extras ParseLineWithTag20(string sir)
        {
            sir = sir.Replace("\n", "").Replace("\r", "");
            _extras.NumarReferinta = sir;
            return _extras;
        }

        public Extras ParseLineWithTag25(string sir)
        {
            string iban = sir;
            _extras.Iban = iban.Replace("\n", "").Replace("\r", "");
            return _extras;
        }

        public Extras ParseLineWithTag28(string sir)
        {
            sir = sir.Replace("\n", "").Replace("\r", "");
            _extras.NrExtras = sir.Substring(0, 5);
            _extras.NrSecventa = sir.Substring(6);
            _extras.NrSecventa = _extras.NrSecventa.Replace("\n", "").Replace("\r", "");
            return _extras;
        }

        public Extras ParseLineWithTag60(string sir)
        {
            if (sir.Contains(":86:"))
            {
                _extras.CodSoldInitial = sir.Substring(0, 1);
                _extras.DataSoldInitial = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null));
                _extras.ValutaSoldInitial = sir.Substring(7, 3);
                _extras.SumaSoldInitial = Decimal.Parse((Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                _extras.InformatiiPentruClientSoldInitial = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "   ");
            }
            else
            {
                _extras.CodSoldInitial = sir.Substring(0, 1);
                _extras.DataSoldInitial = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null));
                _extras.ValutaSoldInitial = sir.Substring(7, 3);
                _extras.SumaSoldInitial = Decimal.Parse((Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                _extras.InformatiiPentruClientSoldInitial = "";
            }
            return _extras;
        }

        public Tranzactie ParseLineWithTag61(string sir)
        {
            Tranzactie tranzactie = new Tranzactie();
            _tranzactieId += 1;
            tranzactie.TranzactieId = _tranzactieId;
            if (sir.IndexOf(":86:") - sir.IndexOf("/") <= 52)
            {
                tranzactie.DataValutei = (DateTime.ParseExact("20" + sir.Substring(0, 6), "yyyyMMdd", null)).Date;
                tranzactie.DataTranzactie = GetTransactionDate(tranzactie.DataValutei, sir.Substring(6, 4), _extras.DataSoldInitial);
                tranzactie.CodTranzactie = sir.Substring(10, 1);
                tranzactie.SumaTranzactie = Decimal.Parse((Convert.ToDecimal((sir.Substring(11, sir.IndexOf(',') - 11) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                tranzactie.TipTranzactie = sir.Substring(sir.IndexOf(',') + 3, 4);
                tranzactie.ReferintaClient = sir.Substring(sir.IndexOf(',') + 7, 16);
                tranzactie.DetaliiTranzactie = "";
                tranzactie.InformatiiPentruClient = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            else
            {
                tranzactie.DataValutei = (DateTime.ParseExact("20" + sir.Substring(0, 6), "yyyyMMdd", null)).Date;
                tranzactie.DataTranzactie = GetTransactionDate(tranzactie.DataValutei, sir.Substring(6, 4), _extras.DataSoldInitial);
                tranzactie.CodTranzactie = sir.Substring(10, 1);
                tranzactie.SumaTranzactie = Decimal.Parse((Convert.ToDecimal((sir.Substring(11, sir.IndexOf(',') - 11) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                tranzactie.TipTranzactie = sir.Substring(sir.IndexOf(',') + 3, 4);
                tranzactie.ReferintaClient = sir.Substring(sir.IndexOf(',') + 7, 16);
                tranzactie.DetaliiTranzactie = sir.Substring(sir.IndexOf(',') + 74, sir.IndexOf(":86:") - sir.IndexOf(',') + 74);
                tranzactie.InformatiiPentruClient = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            return tranzactie;
        }

        private DateTime GetTransactionDate(DateTime tranzactieDataValutei, string dataExtrasa, DateTime dataSoldInitial)
        {
            List<int> listTransactionDate = new List<int>();
            var previousYearEntryDate = Convert.ToInt32(Convert.ToString(tranzactieDataValutei.Year - 1) + dataExtrasa);
            var currentYearEntryDate = Convert.ToInt32(Convert.ToString(tranzactieDataValutei.Year) + dataExtrasa);
            var nextYearEntryDate = Convert.ToInt32(Convert.ToString(tranzactieDataValutei.Year + 1) + dataExtrasa);
            listTransactionDate.Add(Math.Abs(previousYearEntryDate - Convert.ToInt32(Convert.ToString(dataSoldInitial.Year)+ Convert.ToString(dataSoldInitial.Month)+ Convert.ToString(dataSoldInitial.Day))));
            listTransactionDate.Add(Math.Abs(currentYearEntryDate - Convert.ToInt32(Convert.ToString(dataSoldInitial.Year) + Convert.ToString(dataSoldInitial.Month) + Convert.ToString(dataSoldInitial.Day))));
            listTransactionDate.Add(Math.Abs(nextYearEntryDate - Convert.ToInt32(Convert.ToString(dataSoldInitial.Year) + Convert.ToString(dataSoldInitial.Month) + Convert.ToString(dataSoldInitial.Day))));
            if (listTransactionDate.Min() == listTransactionDate[0])
            {
                return DateTime.ParseExact(Convert.ToString(previousYearEntryDate), "yyyyMMdd", null).Date;
            }
            else if (listTransactionDate.Min() == listTransactionDate[1])
            {
                return DateTime.ParseExact(Convert.ToString(currentYearEntryDate), "yyyyMMdd", null).Date;
            }
            else
            {
                return DateTime.ParseExact(Convert.ToString(nextYearEntryDate), "yyyyMMdd", null).Date;
            }
        }

        public Extras ParseLineWithTag62(string sir)
        {
            if (sir.Contains(":86:"))
            {
                _extras.CodSoldFinalRezervat = sir.Substring(0, 1);
                _extras.DataSoldRezervat = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldRezervat = sir.Substring(7, 3);
                _extras.SumaSoldRezervat = Decimal.Parse((Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                _extras.InformatiiPentruClientSoldRezervat = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "   ");
            }
            else
            {
                _extras.CodSoldFinalRezervat = sir.Substring(0, 1);
                _extras.DataSoldRezervat = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldRezervat = sir.Substring(7, 3);
                _extras.SumaSoldRezervat = Decimal.Parse((Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                _extras.InformatiiPentruClientSoldRezervat = "";
            }
            return _extras;
        }

        public Extras ParseLineWithTag64(string sir)
        {
            if (sir.Contains(":86:"))
            {
                _extras.CodSoldFinalDisponibil = sir.Substring(0, 1);
                _extras.DataSoldFinalDisponibil = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldFinalDisponibil = sir.Substring(7, 3);
                _extras.SumaSoldFinalDisponibil = Decimal.Parse((Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                _extras.InformatiiPentruClientSoldFinalDisponibil = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            else
            {
                _extras.CodSoldFinalDisponibil = sir.Substring(0, 1);
                _extras.DataSoldFinalDisponibil = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldFinalDisponibil = sir.Substring(7, 3);
                _extras.SumaSoldFinalDisponibil = Decimal.Parse((Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                _extras.InformatiiPentruClientSoldFinalDisponibil = "";
            }
            return _extras;
        }

        public Extras ParseLineWithTag65(string sir)
        {
            if (sir.Contains(":86:"))
            {
                _extras.CodSoldDisponibil = sir.Substring(0, 1);
                _extras.DataSoldDisponibil = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldDisponibil = sir.Substring(7, 3);
                _extras.SumaSoldDisponibil = Decimal.Parse((Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                _extras.InformatiiPentruClientSoldDisponibil = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "     ");
            }
            else
            {
                _extras.CodSoldDisponibil = sir.Substring(0, 1);
                _extras.DataSoldDisponibil = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldDisponibil = sir.Substring(7, 3);
                _extras.SumaSoldDisponibil = Decimal.Parse((Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100).ToString("0.00"));
                _extras.InformatiiPentruClientSoldDisponibil = "";
            }
            return _extras;
        }

        public Extras InternalParse(string[] randuriFisier, int inderRandPrimit)
        {
            _extras = new Extras();
            string randNetichetat = "";
            bool isExtrasValid = false;


            for (; inderRandPrimit < randuriFisier.Length; inderRandPrimit += 1)
            {
                if (!String.IsNullOrEmpty(randuriFisier[inderRandPrimit]))
                {
                    break;
                }
            }

            for (int indexRandCurent = inderRandPrimit; indexRandCurent < randuriFisier.Length; indexRandCurent += 1)
            {
                if (randuriFisier[indexRandCurent].StartsWith(":20:"))
                {
                    isExtrasValid = true;
                    ParseLineWithTag20(randuriFisier[indexRandCurent].Substring(4));
                }

                if (randuriFisier[indexRandCurent].StartsWith(":25:"))
                {
                    ParseLineWithTag25(randuriFisier[indexRandCurent].Substring(4));
                }

                if (randuriFisier[indexRandCurent].StartsWith(":28C:"))
                {
                    ParseLineWithTag28(randuriFisier[indexRandCurent].Substring(5));
                }

                if (randuriFisier[indexRandCurent].StartsWith(":60F:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(randuriFisier, indexRandCurent);
                    randuriFisier[indexRandCurent] = randuriFisier[indexRandCurent] + randNetichetat;
                    ParseLineWithTag60(randuriFisier[indexRandCurent].Substring(5));
                }

                if (randuriFisier[indexRandCurent].StartsWith(":61:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(randuriFisier, indexRandCurent);
                    randuriFisier[indexRandCurent] = randuriFisier[indexRandCurent] + randNetichetat;
                    _extras.Tranzactii.Add(ParseLineWithTag61(randuriFisier[indexRandCurent].Substring(4)));
                }

                if (randuriFisier[indexRandCurent].StartsWith(":62F:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(randuriFisier, indexRandCurent);
                    randuriFisier[indexRandCurent] = randuriFisier[indexRandCurent] + randNetichetat;
                    ParseLineWithTag62(randuriFisier[indexRandCurent].Substring(5));
                }

                if (randuriFisier[indexRandCurent].Contains(":64:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(randuriFisier, indexRandCurent);
                    randuriFisier[indexRandCurent] = randuriFisier[indexRandCurent] + randNetichetat;
                    ParseLineWithTag64(randuriFisier[indexRandCurent].Substring(4));
                }

                if (randuriFisier[indexRandCurent].Contains(":65:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(randuriFisier, indexRandCurent);
                    randuriFisier[indexRandCurent] = randuriFisier[indexRandCurent] + randNetichetat;
                    ParseLineWithTag65(randuriFisier[indexRandCurent].Substring(4));
                }

                if (randuriFisier[indexRandCurent].StartsWith("-}") || randuriFisier[indexRandCurent].Equals(""))
                {
                    _lastProcessedLineIndex = indexRandCurent + 1;
                    break;
                }
            }

            if (isExtrasValid)
            {
                _extrasId += 1;
                _extras.ExtrasId = _extrasId;
                return _extras;
            }
            else
            {
                return null;
            }

        }

        public List<Extras> Parse(string[] randuriFisier)
        {
            List<Extras> listaExtrase = new List<Extras>();
            _lastProcessedLineIndex = 0;
            do
            {
                Extras extras = InternalParse(randuriFisier, _lastProcessedLineIndex);
                if (extras != null)
                {
                    listaExtrase.Add(extras);
                }
            } while (_lastProcessedLineIndex < randuriFisier.Length);

            return listaExtrase;
        }

        public string ConcatenareRanduriDetalii(string[] randuriFisier, int indexRandCurent)
        {
            string randNetichetat = "";
            for (int indexRandFaraTagSauCuTag86 = indexRandCurent + 1; indexRandFaraTagSauCuTag86 < randuriFisier.Length; indexRandFaraTagSauCuTag86 += 1)
            {
                if (!randuriFisier[indexRandFaraTagSauCuTag86].StartsWith(":6") && !randuriFisier[indexRandFaraTagSauCuTag86].StartsWith("-}") && !String.IsNullOrWhiteSpace(randuriFisier[indexRandFaraTagSauCuTag86]))
                {
                    randNetichetat += randuriFisier[indexRandFaraTagSauCuTag86];
                }
                if (String.IsNullOrWhiteSpace(randuriFisier[indexRandFaraTagSauCuTag86]) || randuriFisier[indexRandFaraTagSauCuTag86].Contains("-}") || randuriFisier[indexRandFaraTagSauCuTag86].StartsWith(":6"))
                {
                    break;
                }

            }
            return randNetichetat;
        }
    }

    public interface IExtrasParser
    {
        List<Extras> Parse(string[] randuriFisier);
    }
}
