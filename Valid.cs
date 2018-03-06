using System;
using System.Diagnostics;
using System.Text.RegularExpressions;


namespace Validator_static
{
    class Valid
    {
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
            _source.TraceEvent(TraceEventType.Verbose, 0, "Validator started");

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
                        if (stundas > 0)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins,"DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose , 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli kļūda");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 2, "Nav kļūdu");
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        _source.TraceEvent(TraceEventType.Verbose, 3, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”) kļūda");
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > 0)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\")kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli kļūda");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }

                        }

                    }
                }
                else
                {
                    _source.TraceEvent(TraceEventType.Verbose, 2, " Pārbauda vai varchar satur 11-zīmīgu skaitli kļūda");
                    //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām ("pieaugušo neformālā izgītība" vai "interešu izglītība")
                    if (programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība")
                    {
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > 0)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda ");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli kļūda");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose , 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        _source.TraceEvent(TraceEventType.Verbose, 3, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”) kļūda");
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > 0)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "dd.MM.yyyy. - dd.MM.yyyy."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose,7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli kļūda");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda ");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }

                        }

                    }
                }
            }
            else
            {
                _source.TraceEvent(TraceEventType.Verbose, 1, "Pārbauda vai Uzņēmuma nosaukums reģistrēts kļūda");

                //Pārbauda vai varchar satur 11-zīmīgu skaitli
                if (registracijasnumurs.Length == 11)
                {
                    //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām ("pieaugušo neformālā izgītība" vai "interešu izglītība")
                    if (programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība")
                    {
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > 0)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose,7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli kļūda");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        _source.TraceEvent(TraceEventType.Verbose, 1, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”) kļūda");
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > 0)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli kļūda");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }

                        }

                    }
                }
                else
                {
                    _source.TraceEvent(TraceEventType.Verbose, 2, " Pārbauda vai varchar satur 11-zīmīgu skaitli kļūda");
                    //Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām ("pieaugušo neformālā izgītība" vai "interešu izglītība")
                    if (programmasveids == "pieaugušo neformālā izglītība" || programmasveids == "interešu izglītība")
                    {
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > 0)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli kļūda");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }

                        }
                    }
                    else
                    {
                        _source.TraceEvent(TraceEventType.Verbose, 1, "Pārbauda, vai varchar satur vienu no 2 atļautām vērtībām (“pieaugušo neformālā izglītība” vai “ interešu izglītība”) kļūda");
                        //Pārbauda vai varchar satur pozitīvu skaitli
                        if (stundas > 0)
                        {
                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose,7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                        }
                        else
                        {
                            _source.TraceEvent(TraceEventType.Verbose, 4, "Pārbauda vai varchar satur pozitīvu skaitli kļūda");

                            //Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām ("pagarināt" vai "izsniegt")
                            if (lemums == "pagarināt" || lemums == "izsniegt")
                            {
                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }
                            else
                            {
                                _source.TraceEvent(TraceEventType.Verbose, 5, "Pārbauda vai varchar satur vienu no 2 atļautajām vērtībām (\"pagarināt\" vai \"izsniegt\") kļūda");


                                //Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”)
                                if (Regex.IsMatch(termins, "DD.MM.YYYY. - DD.MM.YYYY."))
                                {
                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).
                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {
                                       
                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                                else
                                {
                                    _source.TraceEvent(TraceEventType.Verbose, 6, "Pārbauda, vai varchar satur datumu formātā - (“DD.MM.YYYY. -  DD.MM.YYYY.”) kļūda");

                                    //Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”).

                                    if (Regex.IsMatch(licencesnumurs, "DIKS-YY-ID-ail"))
                                    {

                                        return true;
                                    }
                                    else
                                    {
                                        _source.TraceEvent(TraceEventType.Verbose, 7, "Pārbauda, vai varchar satur simbolus formātā - (“DIKS-YY-ID-ail”). kļūda");
                                    }
                                }
                            }

                        }

                    }
                }

            }


            _source.TraceEvent(TraceEventType.Verbose, 0, "Validator ended");
            return true;
        }

    }
}
