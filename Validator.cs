using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Validator_static
{
    public partial class Validator : Form
    {
        DataGridView grid { get; set; }
        public Validator()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(500, 600);
            //ielādē datus
            var dt = LoadData();

            // izveido grid un pieliek datus
         grid =    new DataGridView()
            {
                Parent = this,
                Dock = DockStyle.Fill,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill,
                AllowUserToDeleteRows = false,
                DataSource = dt
            };

            var button = new Button { Dock = DockStyle.Bottom, Width = 100, Parent = this, Text = "Nospied" };

            //lai nospiežot kaut kas notiek

            button.Click += Button_Click;

        }

        private void Button_Click(object sender, EventArgs e)
        {
            var validator = new Valid_2();
            var dt = (DataTable)grid.DataSource;
            foreach (DataRow  row in dt.Rows)
            {
                validator.id = (long)row["ID"];
                validator.licencespieprasitajs = row["Licences-pieprasitajs"].ToString();
                validator.registracijasnumurs = row["Registracijas-numurs"].ToString();
                validator.programmasnosaukums = row["Programmas-nosaukums"].ToString();
                validator.programmasveids = row["Programmas-veids"].ToString();
                validator.realizacijasvieta = row["Realizacijas-vieta"].ToString();
                validator.stundas =  (row["Stundas"].ToString() == "") ? 0 : Convert.ToInt32(row["Stundas"].ToString());
                validator.lemums = row["Lemums"].ToString();
                validator.termins = row["Termins"].ToString();
                validator.licencesnumurs =row["Licences-numurs"].ToString();
                validator.Validator();
            }
         


        }

        DataTable LoadData()
        {
            var dt = new DataTable();
           
            using ( var connection = new SQLiteConnection(@"Data Source=C:\Bakalaurs\Validator_static\Validator_static\licences.db;Version=3;"))
            {
                connection.Open();

                using (var adapter = new SQLiteDataAdapter())
                {
                    using (var cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = "SELECT * FROM [Licences-2013]";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(dt);
                    }
                }
            }
            //dt.Columns.Add("Licences-Pieprasitajs",typeof(string));
            //dt.Columns.Add("Registracijas-numurs",typeof(string));
            //dt.Columns.Add("Programmas-nosaukums", typeof(string));
            //dt.Columns.Add("Programmas-veids", typeof(string));
            //dt.Columns.Add("Realiacijas-vieta", typeof(string));
            //dt.Columns.Add("Stundas", typeof(int));
            //dt.Columns.Add("Lemums", typeof(string));
            //dt.Columns.Add("Termins", typeof(DateTime));
            //dt.Columns.Add("Licences-numurs", typeof(string));

            //dt.Rows.Add("Klavs", "12345678910", "Test",
            //   "Nepareizs", "Latvija", 2, 
            //   "pagarināt", "04/03/2018", "Numurs");
            //return dt;

            return dt;

        }





   
    }
}
