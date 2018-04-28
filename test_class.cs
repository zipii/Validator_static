using System;
using System.Data.SqlClient;
using System.Data;
public class Valid
{
    private DataTable data = new DataTable();
    public void Validator()
    {
        using (var connection = new SqlConnection("server = DELL; uid = data; pwd = !@#qazWSX; database = Data_quality"))
        {
            connection.Open();
            using (var adapter = new SqlDataAdapter())
            {
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = connection;
                    //Assesst Field "Reg_number"

                    cmd.CommandText = @"select * from [dbo].register where regcode IS NULL OR LEN(RIGHT(regcode,(LEN(regcode) ) + 1)) <> 9  AND LEN(RIGHT(regcode,(LEN(regcode) ) + 1)) <>11";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID ,1  from [dbo].register where regcode IS NULL OR LEN(RIGHT(regcode,(LEN(regcode) ) + 1)) <> 9  AND LEN(RIGHT(regcode,(LEN(regcode) ) + 1)) <>11";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field \"sepa\"

                    cmd.CommandText = @"select * from [dbo].register where sepa IS NOT NULL
AND sepa NOT LIKE 'LV[0-9][0-9]ZZZ[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID ,2  from [dbo].register where sepa IS NOT NULL AND sepa NOT LIKE 'LV[0-9][0-9]ZZZ[0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9][0-9]'";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Name"

                    cmd.CommandText = @"select * from [dbo].register where name IS NULL";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID,3  from [dbo].register where name IS NULL";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "RegType"

                    cmd.CommandText = @"select * from [dbo].register where regtype IS NOT NULL 
AND LEN(regtype) <> 1
AND (regtype NOT LIKE 'K'  AND regtype  NOT LIKE 'U' and regtype NOT LIKE 'B'
AND regtype  NOT LIKE 'M' AND regtype  NOT LIKE 'R' and regtype NOT LIKE 'S' AND regtype  NOT LIKE 'C' AND regtype  NOT LIKE 'E'
AND regtype  NOT LIKE 'A' AND regtype  NOT LIKE 'P' and regtype NOT LIKE 'T' AND regtype  NOT LIKE 'O')";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID,4  from [dbo].register where regtype IS NOT NULL  AND LEN(regtype) <> 1 AND (regtype NOT LIKE 'K'  AND regtype  NOT LIKE 'U' and regtype NOT LIKE 'B' AND regtype  NOT LIKE 'M' AND regtype  NOT LIKE 'R' and regtype NOT LIKE 'S' AND regtype  NOT LIKE 'C' AND regtype  NOT LIKE 'E'AND regtype  NOT LIKE 'A' AND regtype  NOT LIKE 'P' and regtype NOT LIKE 'T' AND regtype  NOT LIKE 'O')";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Type"

                    cmd.CommandText = @"select * from [dbo].register where type IS NOT NULL
AND type NOT LIKE 'SIA' AND type NOT LIKE 'AS' 
AND type NOT LIKE 'ZEM' AND type NOT LIKE 'MIL' 
AND type NOT LIKE 'BDR' AND type NOT LIKE 'IK' 
AND type NOT LIKE 'IND' AND type NOT LIKE 'NOD' 
AND type NOT LIKE 'KB' AND type NOT LIKE 'FIL' 
AND type NOT LIKE 'KAT' AND type NOT LIKE 'DRZ' 
AND type NOT LIKE 'PP' AND type NOT LIKE 'PSV' 
AND type NOT LIKE 'SAV' AND type NOT LIKE 'AKF'
AND type NOT LIKE 'ARV' AND type NOT LIKE 'PAR'
AND type NOT LIKE 'SKT' AND type NOT LIKE 'PS'
AND type NOT LIKE 'ZVJ' AND type NOT LIKE 'EIG'
AND type NOT LIKE 'BAZ' AND type NOT LIKE 'ARB'
AND type NOT LIKE 'POR' AND type NOT LIKE 'SAB'
AND type NOT LIKE 'KS' AND type NOT LIKE 'PPA'
AND type NOT LIKE 'PAJ' AND type NOT LIKE 'PRV'
AND type NOT LIKE 'ARA' AND type NOT LIKE 'DRJ'
AND type NOT LIKE 'SPO' AND type NOT LIKE 'VU'
AND type NOT LIKE 'ASF' AND type NOT LIKE 'ROI'
AND type NOT LIKE 'KBS' AND type NOT LIKE 'GIM'
AND type NOT LIKE 'LIG' AND type NOT LIKE 'KLO'
AND type NOT LIKE 'SE' AND type NOT LIKE 'KBU'
AND type NOT LIKE 'SAA' AND type NOT LIKE 'SOU'
AND type NOT LIKE 'POL' AND type NOT LIKE 'KOR'
AND type NOT LIKE 'SPA' AND type NOT LIKE 'PRO'
AND type NOT LIKE 'UZN' AND type NOT LIKE 'KSS'
AND type NOT LIKE 'PAP' AND type NOT LIKE 'REL'
AND type NOT LIKE 'MIS' AND type NOT LIKE 'BIE'
AND type NOT LIKE 'DIE' 
'IK')";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 4 from [dbo].register where type IS NOT NULL AND type NOT LIKE 'SIA' AND type NOT LIKE 'AS' AND type NOT LIKE 'ZEM' AND type NOT LIKE 'MIL'  AND type NOT LIKE 'BDR' AND type NOT LIKE 'IK' AND type NOT LIKE 'IND' AND type NOT LIKE 'NOD' AND type NOT LIKE 'KB' AND type NOT LIKE 'FIL' AND type NOT LIKE 'KAT' AND type NOT LIKE 'DRZ'  AND type NOT LIKE 'PP' AND type NOT LIKE 'PSV' AND type NOT LIKE 'SAV' AND type NOT LIKE 'AKF'AND type NOT LIKE 'ARV' AND type NOT LIKE 'PAR'AND type NOT LIKE 'SKT' AND type NOT LIKE 'PS'AND type NOT LIKE 'ZVJ' AND type NOT LIKE 'EIG'AND type NOT LIKE 'BAZ' AND type NOT LIKE 'ARB'AND type NOT LIKE 'POR' AND type NOT LIKE 'SAB'AND type NOT LIKE 'KS' AND type NOT LIKE 'PPA'AND type NOT LIKE 'PAJ' AND type NOT LIKE 'PRV'AND type NOT LIKE 'ARA' AND type NOT LIKE 'DRJ'AND type NOT LIKE 'SPO' AND type NOT LIKE 'VU'AND type NOT LIKE 'ASF' AND type NOT LIKE 'ROI'";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field Type_text

                    cmd.CommandText = @"select * from [dbo].register where type IS NOT NULL AND type_text IS NULL";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID,5 from [dbo].register where type IS NOT NULL AND type_text IS NULL";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Address"

                    cmd.CommandText = @"select * from [dbo].register where addressid IS NOT NULL AND addressid NOT LIKE '0' AND address IS  NULL";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID,6 from [dbo].register where addressid IS NOT NULL AND addressid NOT LIKE '0' AND address IS  NULL";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Address_id"

                    cmd.CommandText = @"select * from [dbo].register where addressid IS NOT NULL AND LEN(CAST(addressid AS numeric)) <> 9";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 7  from [dbo].register where addressid IS NOT NULL AND LEN(CAST(addressid AS numeric)) <> 9";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Index"

                    cmd.CommandText = @"select * from [dbo].register where register.[index] IS NOT NULL 
AND LEN(CAST(register.[index] AS numeric)) <> 4";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 8  from [dbo].register where register.[index] IS NOT NULL AND LEN(CAST(register.[index] AS numeric)) <> 4";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Closed"

                    cmd.CommandText = @"select * from [dbo].register where closed IS NOT NULL 
AND closed NOT LIKE 'L' AND closed NOT LIKE 'R'";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 9  from [dbo].register where closed IS NOT NULL AND closed NOT LIKE 'L' AND closed NOT LIKE 'R'";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Terminated"

                    cmd.CommandText = @"select * from [dbo].register where terminated IS NOT NULL
AND (closed NOT LIKE 'R' AND closed NOT LIKE 'L')  	";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 10  from [dbo].register where terminated IS NOT NULL AND (closed NOT LIKE 'R' AND closed NOT LIKE 'L')";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Region"

                    cmd.CommandText = @"select * from [dbo].register where region IS NOT NULL AND region NOT LIKE '0'  AND LEN(CAST(region AS numeric)) <> 9";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 11  from [dbo].register where region IS NOT NULL AND region NOT LIKE '0'  AND LEN(CAST(region AS numeric)) <> 9";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "City"

                    cmd.CommandText = @"select * from [dbo].register where city IS NOT NULL AND city NOT LIKE '0' AND LEN(CAST(city AS numeric)) <> 9";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 12  from [dbo].register where city IS NOT NULL AND city NOT LIKE '0' AND LEN(CAST(city AS numeric)) <> 9";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "ATV_code"

                    cmd.CommandText = @"select * from [dbo].register where atvk IS NOT NULL AND LEN(atvk) <> 7";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 13  from [dbo].register where atvk IS NOT NULL AND LEN(atvk) <> 7";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Date"

                    cmd.CommandText = @"select * from [dbo].register where registered IS NOT NULL AND ISDATE(registered)=0";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 14  from [dbo].register where registered IS NOT NULL AND ISDATE(registered)=0";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "Terminated"

                    cmd.CommandText = @"select * from [dbo].register where terminated IS NOT NULL AND ISDATE(terminated)=0";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 15  from [dbo].register where terminated IS NOT NULL AND ISDATE(terminated)=0";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                    //Assesst Field "reregistration_term"

                    cmd.CommandText = @"select * from [dbo].register where [reregistration_term] IS NOT NULL AND ISDATE([reregistration_term])=0";
                    adapter.SelectCommand = cmd;
                    adapter.Fill(data);
                    // Pārbaudam vai kat kas atbilst nosacījumiem
                    if (data.Rows.Count > 0)
                    {





                        cmd.CommandText = "insert into registerLV_errors select ID, 16  from [dbo].register where [reregistration_term] IS NOT NULL AND ISDATE([reregistration_term])=0";
                        cmd.ExecuteNonQuery();

                    }
                    else
                    {
                    }

                    data.Clear();

                }
            }
        }
    }
}
