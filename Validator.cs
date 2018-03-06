using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            var validator = new Valid();

            validator.licencespieprasitajs = "Klavs";
            validator.registracijasnumurs = "1234568910";
            validator.programmasnosaukums = "Test";
            validator.programmasveids = "Nepareizs";
            validator.realizacijasvieta = "Latvija";
            validator.stundas = 2;
            validator.lemums = "pagarināt";
            validator.termins = "04.03.2018. - 05.03.2018";
            validator.licencesnumurs = "Numurs";
            validator.Validator();


        }

        DataTable LoadData()
        {
            var dt = new DataTable();
            dt.Columns.Add("Licences-Pieprasitajs",typeof(string));
            dt.Columns.Add("Registracijas-numurs",typeof(string));
            dt.Columns.Add("Programmas-nosaukums", typeof(string));
            dt.Columns.Add("Programmas-veids", typeof(string));
            dt.Columns.Add("Realiacijas-vieta", typeof(string));
            dt.Columns.Add("Stundas", typeof(int));
            dt.Columns.Add("Lemums", typeof(string));
            dt.Columns.Add("Termins", typeof(DateTime));
            dt.Columns.Add("Licences-numurs", typeof(string));

            dt.Rows.Add("Klavs", "12345678910", "Test",
               "Nepareizs", "Latvija", 2, 
               "pagarināt", "04/03/2018", "Numurs");
            return dt;

        }





   
    }
}
