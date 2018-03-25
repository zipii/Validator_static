using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validator_static
{
    class Valid_2
    {
        public long id;
        public string licencespieprasitajs;
        public string registracijasnumurs;
        public string programmasnosaukums;

        public string programmasveids;
        public string realizacijasvieta;
        public int stundas;

        public string lemums;
        public string termins;
        public string licencesnumurs;

        private static TraceSource _source = new TraceSource("quality");

        public bool Validator ()
        {
            _source.TraceEvent(TraceEventType.Verbose, 0, "Sākums " + id.ToString());
            //Pārbauda vai Uzņēmuma nosaukums reģistrēts
            if (licencespieprasitajs != null)
            {

            }
            else
            {
                _source.TraceEvent(TraceEventType.Verbose, 1, "Pārbauda vai Uzņēmuma nosaukums reģistrēts kļūda");
            }

            //Pārbauda vai varchar satur 11-zīmīgu skaitli
            if (registracijasnumurs.Length == 11)
            {

            }
            else
            {
                _source.TraceEvent(TraceEventType.Verbose, 2, "Pārbauda vai varchar satur 11-zīmīgu skaitli");
            }

            // Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”)
            if (programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība")
            {

            }
            else
            {
                _source.TraceEvent(TraceEventType.Verbose, 3, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”)");
            }
            //Pārbauda vai varchar satur pozitīvu skaitli
            if (stundas > 0)
            {

            }
            else
            {
                _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli");
            }
            //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pagarināt” vai ”izsniegt”)
            if (lemums.Contains( "pagarināt") || lemums.Contains ("izsniegt"))
            {

            }
            else
            {
                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pagarināt” vai ”izsniegt”)");
            }

            // Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
            if (Regex.IsMatch(termins, @"(3[01]|[12][0-9]|0?[1-9])\.(1[012]|0?[1-9])\.((?:19|20)\d{2})\.-(3[01]|[12][0-9]|0?[1-9])\.(1[012]|0?[1-9])\.((?:19|20)\d{2})\."))
            {

            }
            else
            {
                _source.TraceEvent(TraceEventType.Verbose, 6, " Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");
            }
            //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
            if (Regex.IsMatch(licencesnumurs, @"DIKS-(\d\d)-(\d+)-ail") && licencesnumurs.Contains(id.ToString()))
            {
                
            }
            else
            {
                _source.TraceEvent(TraceEventType.Verbose, 7, " Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”)");
            }
            _source.TraceEvent(TraceEventType.Verbose, 0, "Beigas " + id.ToString());
            return true;
        }

    }
}
