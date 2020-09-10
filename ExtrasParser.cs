using System;
using System.Collections.Generic;

namespace BankStatementReader
{
    public class ExtrasParser : IExtrasParser
    {
        Extras _extras;
        private int _lastProcessedLineIndex;
        private int _extrasId = 0;
        private int _tranzactieId = 0;

        public Extras Tag20(string sir)
        {
            sir = sir.Replace("\n", "").Replace("\r", "");
            _extras.NumarReferinta = sir;
            return _extras;
        }

        public Extras Tag25(string sir)
        {
            string iban = sir;
            _extras.Iban = iban.Replace("\n", "").Replace("\r", "");
            return _extras;
        }

        public Extras Tag28(string sir)
        {
            sir = sir.Replace("\n", "").Replace("\r", "");
            _extras.NrExtras = sir.Substring(0, 5);
            _extras.NrSecventa = sir.Substring(6);
            _extras.NrSecventa = _extras.NrSecventa.Replace("\n", "").Replace("\r", "");
            return _extras;
        }

        public Extras Tag60(string sir)
        {
            if (sir.Contains(":86:"))
            {
                _extras.CodSoldInitial = sir.Substring(0, 1);
                _extras.DataSoldInitial = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null));
                _extras.ValutaSoldInitial = sir.Substring(7, 3);
                _extras.SumaSoldInitial = Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100;
                _extras.InformatiiPentruClientSoldInitial = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            else
            {
                _extras.CodSoldInitial = sir.Substring(0, 1);
                _extras.DataSoldInitial = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null));
                _extras.ValutaSoldInitial = sir.Substring(7, 3);
                _extras.SumaSoldInitial = Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100;
                _extras.InformatiiPentruClientSoldInitial = "";
            }
            return _extras;
        }

        public Tranzactie Tag61(string sir)
        {
            Tranzactie tranzactie = new Tranzactie();
            _tranzactieId += 1;
            tranzactie.TranzactieId = _tranzactieId;
            if (sir.IndexOf(":86:") - sir.IndexOf("/") <= 52)
            {
                tranzactie.DataTranzactie = (DateTime.ParseExact("20" + sir.Substring(0, 6), "yyyyMMdd", null)).Date;
                tranzactie.CodTranzactie = sir.Substring(10, 1);
                tranzactie.SumaTranzactie = Convert.ToDecimal(sir.Substring(11, sir.IndexOf(',') - 11) + sir.Substring(sir.IndexOf(','), 3)) / 100;
                tranzactie.TipTranzactie = sir.Substring(sir.IndexOf(',') + 3, 4);
                tranzactie.ReferintaClient = sir.Substring(sir.IndexOf(',') + 7, 16);
                tranzactie.DetaliiTranzactie = "";
                tranzactie.InformatiiPentruClient = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            else
            {
                tranzactie.DataTranzactie = (DateTime.ParseExact("20" + sir.Substring(0, 6), "yyyyMMdd", null)).Date;
                tranzactie.CodTranzactie = sir.Substring(10, 1);
                tranzactie.SumaTranzactie = Convert.ToDecimal(sir.Substring(11, sir.IndexOf(',') - 11) + sir.Substring(sir.IndexOf(','), 3)) / 100;
                tranzactie.TipTranzactie = sir.Substring(sir.IndexOf(',') + 3, 4);
                tranzactie.ReferintaClient = sir.Substring(sir.IndexOf(',') + 7, 16);
                tranzactie.DetaliiTranzactie = sir.Substring(sir.IndexOf(',') + 74, sir.IndexOf(":86:") - sir.IndexOf(',') + 74);
                tranzactie.InformatiiPentruClient = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            return tranzactie;
        }

        public Extras Tag62(string sir)
        {
            if (sir.Contains(":86:"))
            {
                _extras.CodSoldFinalRezervat = sir.Substring(0, 1);
                _extras.DataSoldRezervat = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldRezervat = sir.Substring(7, 3);
                _extras.SumaSoldRezervat = Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100;
                _extras.InformatiiPentruClientSoldRezervat = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            else
            {
                _extras.CodSoldFinalRezervat = sir.Substring(0, 1);
                _extras.DataSoldRezervat = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldRezervat = sir.Substring(7, 3);
                _extras.SumaSoldRezervat = Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100;
                _extras.InformatiiPentruClientSoldRezervat = "";
            }
            return _extras;
        }

        public Extras Tag64(string sir)
        {
            if (sir.Contains(":86:"))
            {
                _extras.CodSoldFinalDisponibil = sir.Substring(0, 1);
                _extras.DataSoldFinalDisponibil = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldFinalDisponibil = sir.Substring(7, 3);
                _extras.SumaSoldFinalDisponibil = Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100;
                _extras.InformatiiPentruClientSoldFinalDisponibil = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            else
            {
                _extras.CodSoldFinalDisponibil = sir.Substring(0, 1);
                _extras.DataSoldFinalDisponibil = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldFinalDisponibil = sir.Substring(7, 3);
                _extras.SumaSoldFinalDisponibil = Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100;
                _extras.InformatiiPentruClientSoldFinalDisponibil = "";
            }
            return _extras;
        }

        public Extras Tag65(string sir)
        {
            if (sir.Contains(":86:"))
            {
                _extras.CodSoldDisponibil = sir.Substring(0, 1);
                _extras.DataSoldDisponibil = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldDisponibil = sir.Substring(7, 3);
                _extras.SumaSoldDisponibil = Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100;
                _extras.InformatiiPentruClientSoldDisponibil = sir.Substring(sir.IndexOf(":86:") + 4).Replace(":86:", "    ");
            }
            else
            {
                _extras.CodSoldDisponibil = sir.Substring(0, 1);
                _extras.DataSoldDisponibil = (DateTime.ParseExact("20" + sir.Substring(1, 6), "yyyyMMdd", null)).Date;
                _extras.ValutaSoldDisponibil = sir.Substring(7, 3);
                _extras.SumaSoldDisponibil = Convert.ToDecimal((sir.Substring(10, sir.IndexOf(',') - 10) + sir.Substring(sir.IndexOf(','), 3)).Replace("\n", "").Replace("\r", "")) / 100;
                _extras.InformatiiPentruClientSoldDisponibil = "";
            }
            return _extras;
        }

        public Extras InternalParse(string[] liniiIntrare, int indexLiniePrimita)
        {
            _extras = new Extras();
            string randNetichetat = "";
            bool isExtrasValid = false;


            for (; indexLiniePrimita < liniiIntrare.Length; indexLiniePrimita += 1)
            {
                if (!String.IsNullOrEmpty(liniiIntrare[indexLiniePrimita]))
                {
                    break;
                }
            }

            for (int linieCurenta = indexLiniePrimita; linieCurenta < liniiIntrare.Length; linieCurenta += 1)
            {
                if (liniiIntrare[linieCurenta].StartsWith(":20:"))
                {
                    isExtrasValid = true;
                    Tag20(liniiIntrare[linieCurenta].Substring(4));
                }

                if (liniiIntrare[linieCurenta].StartsWith(":25:"))
                {
                    Tag25(liniiIntrare[linieCurenta].Substring(4));
                }

                if (liniiIntrare[linieCurenta].StartsWith(":28C:"))
                {
                    Tag28(liniiIntrare[linieCurenta].Substring(5));
                }

                if (liniiIntrare[linieCurenta].StartsWith(":60F:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(liniiIntrare, linieCurenta);
                    liniiIntrare[linieCurenta] = liniiIntrare[linieCurenta] + randNetichetat;
                    Tag60(liniiIntrare[linieCurenta].Substring(5));
                }

                if (liniiIntrare[linieCurenta].StartsWith(":61:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(liniiIntrare, linieCurenta);
                    liniiIntrare[linieCurenta] = liniiIntrare[linieCurenta] + randNetichetat;
                    _extras.Tranzactii.Add(Tag61(liniiIntrare[linieCurenta].Substring(4)));
                }

                if (liniiIntrare[linieCurenta].StartsWith(":62F:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(liniiIntrare, linieCurenta);
                    liniiIntrare[linieCurenta] = liniiIntrare[linieCurenta] + randNetichetat;
                    Tag62(liniiIntrare[linieCurenta].Substring(5));
                }

                if (liniiIntrare[linieCurenta].Contains(":64:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(liniiIntrare, linieCurenta);
                    liniiIntrare[linieCurenta] = liniiIntrare[linieCurenta] + randNetichetat;
                    Tag64(liniiIntrare[linieCurenta].Substring(4));
                }

                if (liniiIntrare[linieCurenta].Contains(":65:"))
                {
                    randNetichetat = ConcatenareRanduriDetalii(liniiIntrare, linieCurenta);
                    liniiIntrare[linieCurenta] = liniiIntrare[linieCurenta] + randNetichetat;
                    Tag65(liniiIntrare[linieCurenta].Substring(4));
                }

                if (liniiIntrare[linieCurenta].StartsWith("-}") || liniiIntrare[linieCurenta].Equals(""))
                {
                    _lastProcessedLineIndex = linieCurenta + 1;
                    break;
                }
            }

            if (isExtrasValid == true)
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

        public List<Extras> Parse(string[] liniiIntrare)
        {
            List<Extras> listaExtrase = new List<Extras>();
            _lastProcessedLineIndex = 0;
            do
            {
                Extras extras = InternalParse(liniiIntrare, _lastProcessedLineIndex);
                if (extras != null)
                {
                    listaExtrase.Add(extras);
                }
            } while (_lastProcessedLineIndex < liniiIntrare.Length);

            return listaExtrase;
        }

        public string ConcatenareRanduriDetalii(string[] liniiIntrare, int linieCurenta)
        {
            string randNetichetat = "";
            for (int linieFaraTagSauCuTag86 = linieCurenta + 1; linieFaraTagSauCuTag86 < liniiIntrare.Length; linieFaraTagSauCuTag86 += 1)
            {
                if (!liniiIntrare[linieFaraTagSauCuTag86].StartsWith(":6") && !liniiIntrare[linieFaraTagSauCuTag86].StartsWith("-}") && !String.IsNullOrWhiteSpace(liniiIntrare[linieFaraTagSauCuTag86]))
                {
                    randNetichetat += liniiIntrare[linieFaraTagSauCuTag86];
                }
                if (String.IsNullOrWhiteSpace(liniiIntrare[linieFaraTagSauCuTag86]) || liniiIntrare[linieFaraTagSauCuTag86].Contains("-}"))
                {
                    break;
                }
            }
            return randNetichetat;
        }
    }

    public interface IExtrasParser
    {
        List<Extras> Parse(string[] liniiIntrare);
    }
}
