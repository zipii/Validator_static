using System;
using System.Text.RegularExpressions;
using System.Diagnostics;
public class Valid
{
    public long id;

    string licencespieprasitajs;
    string registracijasnumurs;
    string programmasnosaukums;
    string programmasveids;
    string realizacijasvieta;
    int stundas;
    string lemums;
    string termins;
    string licencesnumurs;
    private static TraceSource _source = new TraceSource("quality");

    public void Validator()
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
        //Pārbauda vai varchar satur 11-zīmīgi skaitli
        if (registracijasnumurs.Length == 11)
        {
        }
        else
        {
            _source.TraceEvent(TraceEventType.Verbose, 2, "Pārbauda vai varchar satur 11-zīmīgu skaitli");
        }
        //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”)
        if (programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība")
        {
        }
        else
        {
            _source.TraceEvent(TraceEventType.Verbose, 3, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”)");
        }
        //Pārbauda vai varchar satur pozitīvu skaitli
        if (stundas > -1)
        {
        }
        else
        {
            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli");
        }
        //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pagarināt” vai ”izsniegt”)
        if (lemums.Contains("pagarināt") || lemums.Contains("izsniegt"))
        {
        }
        else
        {
            _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pagarināt” vai ”izsniegt”)");
        }
        //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
        if (Regex.IsMatch(termins.ToString(), @"((3[01]|[12][0-9]|0?[1-9])\.(1[012]|0?[1-9])\.((?:19|20)\d{2})\.) - \1"))
        {
        }
        else
        {
            _source.TraceEvent(TraceEventType.Verbose, 6, " Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");
        }
        //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
        if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
        {
        }
        else
        {
            _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”)");
        }

        _source.TraceEvent(TraceEventType.Verbose, 0, "Beigas " + id.ToString());
    }
}
