using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Validator_static
{
    class Valid
    {
        string licencespieprasitajs;
        string registracijasnumurs;
        string programmasnosaukums;
        //enum programmasveids
        //{
        //    pieagušoneformālāizglītība,
        //    interešuizglītība
        //}
        string programmasveids;
        string realizacijasvieta;
        int stundas;
        //enum lemums
        //{
        //    pagaŗināt,
        //    izsniegt
        //}
        string lemums;
        DateTime termins;
        string licencesnumurs;

        private static TraceSource _source = new TraceSource("quality");

        public bool Validator ()
        {
            _source.TraceEvent(TraceEventType.Start, 0, "Validator");

            //Pārbauda vai Uzņēmuma nosaukums reģistrēts
            if (licencespieprasitajs != null )
            {
            
                //Pārbauda vai varchar satur 11-zīmīgu skaitli
                if (registracijasnumurs.Length  == 11)
                {
                    //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām ("pieaugušo neformālā izgītība" vai "interešu izglītība")
                    if(programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība" )
                    {
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > - 1)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(),"DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information , 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur pozitīvu skaitli");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”)");
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > -1)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur pozitīvu skaitli");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }

                        }

                    }
                }
                else
                {
                    _source.TraceEvent(TraceEventType.Information, 1, " Pārbauda vai varchar satur 11-zīmīgu skaitli");
                    //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām ("pieaugušo neformālā izgītība" vai "interešu izglītība")
                    if (programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība")
                    {
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > -1)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur pozitīvu skaitli");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”)");
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > -1)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur pozitīvu skaitli");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }

                        }

                    }
                }
            }
            else
            {
                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai Uzņēmuma nosaukums reģistrēts kļūda");

                //Pārbauda vai varchar satur 11-zīmīgu skaitli
                if (registracijasnumurs.Length == 11)
                {
                    //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām ("pieaugušo neformālā izgītība" vai "interešu izglītība")
                    if (programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība")
                    {
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > -1)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur pozitīvu skaitli");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”)");
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > -1)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur pozitīvu skaitli");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }

                        }

                    }
                }
                else
                {
                    _source.TraceEvent(TraceEventType.Information, 1, " Pārbauda vai varchar satur 11-zīmīgu skaitli");
                    //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām ("pieaugušo neformālā izgītība" vai "interešu izglītība")
                    if (programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība")
                    {
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > -1)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur pozitīvu skaitli");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”)");
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > -1)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur pozitīvu skaitli");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins.ToShortDateString(), "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Information, 1, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).");
                                    }
                                }
                            }

                        }

                    }
                }

            }


            _source.TraceEvent(TraceEventType.Stop, 0, "Validator");
            return true;
        }

    }
}
