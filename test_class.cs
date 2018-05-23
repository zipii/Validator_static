using System;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Linq;
using System.Data;

public class Valid
{
    public long id;

    public string regcode;
    public string sepa;
    public string name;
    public string regtype;
    public string type;
    public string address;
    public string addressid;
    public string index;
    public string closed;
    public string region;
    public string city;
    public string atvk;
    public string registered;
    public string terminated;
    public string reregistration_term;
    public string type_text;
    public DataTable data = new DataTable();
    
   
    
    public Valid()
    {        
        data.Columns.Add("rowid", typeof(long));
        data.Columns.Add("error", typeof(string));
    }
 
   
    private void SendMessage(long rowid, long errornum)
    {
        DataRow dr = data.NewRow();
        dr["rowid"] = rowid;
        dr["error"] = errornum.ToString();
        data.Rows.Add(dr);

    }
    public void Validator()
    {
        //Assesst Field \"Reg_number\"
        if (regcode == null || (regcode.Length != 9 && regcode.Length != 11))
        {
            SendMessage(id, 1);
        }
        else
        {
        }
        //Assesst Field \\\"sepa\\\"
        if (sepa != null && !Regex.IsMatch(sepa, @"LV[0-9][0-9]ZZZ[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]"))
        {
            SendMessage(id, 2);
        }
        else
        {
        }
        //Assesst Field \"Name\"
        if (name == null)
        {
            SendMessage(id, 3);
        }
        else
        {
        }
        //Assesst Field \"RegType\"
        if (regtype != null && regtype.Length != 1 && !new string[] { "K", "U", "B", "M", "R", "S", "C", "E", "A", "T", "O" }.Contains(regtype))
        {
            SendMessage(id, 4);
        }
        else
        {
        }
        //Assesst Field \"Type\"
        if (type != null && !new string[] { "SIA", "AS", "ZEM", "MIL", "BDR", "IK", "IND", "NOD", "KB", "FIL", "KAT", "DRZ", "PP", "PSV", "SAV", "AKF", "ARV", "PAR", "SKT", "PS", "ZVJ", "EIG", "BAZ", "ARB", "POR", "SAB", "KS", "PPA", "PAJ", "PRV", "ARA", "DRJ", "SPO", "VU", "ASF", "ROI", "KBS", "GIM", "LIG", "KLO", "SE", "KBU", "SAA", "SOU", "POL", "KOR", "SPA", "PRO", "UZN", "KSS", "PAP", "REL", "MIS", "BIE", "DIE" }.Contains(type))
        {
            SendMessage(id, 5);
        }
        else
        {
        }
        //Assesst Field Type_text
        if (type != null && type_text == null)
        {
            SendMessage(id, 6);
        }
        else
        {
        }
        //Assesst Field \"Address\"
        if (address == null)
        {
            SendMessage(id, 7);
        }
        else
        {
        }
        //Assesst Field \"Address_id\"
        if (addressid != null && addressid.Length != 9)
        {
            SendMessage(id, 8);
        }
        else
        {
        }
        //Assesst Field \"Index\"
        if (index == null || index.Length != 4)
        {
            SendMessage(id, 9);
        }
        else
        {
        }
        //Assesst Field \"Closed\"
        if (closed != null && new string[] { "L", "R" }.Contains(closed))
        {
            SendMessage(id, 10);
        }
        else
        {
        }
        //Assesst Field \"Terminated\"
        if (terminated != null && new string[] { "R", "L" }.Contains(terminated))
        {
            SendMessage(id, 11);
        }
        else
        {
        }
        //Assesst Field \"Region\"
        if (region != null && region.Contains('0') && region.Length != 9)
        {
            SendMessage(id, 12);
        }
        else
        {
        }
        //Assesst Field \"City\"
        if (city == null || (city != null && city.Contains('0') && city.Length != 9))
        {
            SendMessage(id, 13);
        }
        else
        {
        }
        //Assesst Field \"ATV_code\"
        if (atvk == null || atvk.Length != 7)
        {
            SendMessage(id, 14);
        }
        else
        {
        }

    }

}
