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
        private DataSet graphInformation;

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
            //Grafa izveide
            var graph = LoadGraph();
            Console.Write("test");
            foreach (Node node in graph.Nodes)
            {
                //Iegūst rindas ar pārejām, kas saistītas ar notiekto virsotni 
                var edgeRow = (from edge in graphInformation.Tables[2].AsEnumerable()
                               where edge.Field<long>("EndNodeId") == node.ID || edge.Field<long>("StartNodeId") == node.ID
                               select edge).ToList();

                        
                switch (node.type)
                {   
                    case Type.Sakums:
                        
                        graph.AddDirectedEdge(node, graph.getNodeByID(edgeRow[0].Field<long>("EndNodeId")));

                        break;
                    case Type.Beigas:

                        break;
                    
                    case Type.Zarosanas:
                        foreach (var edge in edgeRow)
                        {   
                            // Ieenākošam zaram apskatām vai nav gadījumā no zarošanās
                            if (edge.Field<String>("Value") == "OK" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                node.branch = Branch.Ok;
                            }
                            else if (edge.Field<String>("value") == "NO" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                node.branch = Branch.No;
                            }
                            else if (edge.Field<String>("value") == "" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                continue;
                            }
                            else
                            {
                                graph.AddDirectedEdge(node, graph.getNodeByID(edge.Field<long>("EndNodeId")));
                            }
                        }

                        break;
                    case Type.Darbiba:
                        foreach (var edge in edgeRow)
                        {

                            if (edge.Field<String>("Value") == "OK" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                node.branch = Branch.Ok;
                            }
                            else if (edge.Field<String>("value") == "NO" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                node.branch = Branch.No;
                            }
                            else if (edge.Field<String>("value") == "" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                continue;
                            }
                            else
                            {
                                graph.AddDirectedEdge(node, graph.getNodeByID(edge.Field<long>("EndNodeId")));
                            }
                        }
                        break;
                    case Type.Apvienosana:
                        foreach (var edge in edgeRow)
                        {
                           
                            if (edge.Field<String>("Value") == "OK" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                node.branch = Branch.Ok;
                            }
                            else if (edge.Field<String>("value") == "NO" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                node.branch = Branch.No;
                            }
                            else if (edge.Field<String>("value") == "" && edge.Field<long>("EndNodeId") == node.ID)
                            {
                                continue;
                            }
                            else
                            {
                                graph.AddDirectedEdge(node, graph.getNodeByID(edge.Field<long>("EndNodeId")));
                            }
                        }
                        break;
               
                }

                Console.Write(node.ID);
            }

            return;



            //var validator = new Valid_2();
            //var dt = (DataTable)grid.DataSource;
            //foreach (DataRow  row in dt.Rows)
            //{
            //    validator.id = (long)row["ID"];
            //    validator.licencespieprasitajs = row["Licences-pieprasitajs"].ToString();
            //    validator.registracijasnumurs = row["Registracijas-numurs"].ToString();
            //    validator.programmasnosaukums = row["Programmas-nosaukums"].ToString();
            //    validator.programmasveids = row["Programmas-veids"].ToString();
            //    validator.realizacijasvieta = row["Realizacijas-vieta"].ToString();
            //    validator.stundas =  (row["Stundas"].ToString() == "") ? 0 : Convert.ToInt32(row["Stundas"].ToString());
            //    validator.lemums = row["Lemums"].ToString();
            //    validator.termins = row["Termins"].ToString();
            //    validator.licencesnumurs =row["Licences-numurs"].ToString();
            //    validator.Validator();
            //}
         


        }

        DataTable LoadData()
        {
            var  dt = new DataTable();
           
            using ( var connection = new SQLiteConnection(@"Data Source=..\..\..\licences.db;Version=3;"))
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


        Graph LoadGraph()
        {
            graphInformation = new DataSet();
            
            using (var connection = new SQLiteConnection(@"Data Source=..\..\..\dbred.sqlite;Version=3;"))
            {
                connection.Open();

                using (var adapter = new SQLiteDataAdapter())
                {
                    using (var cmd = new SQLiteCommand())
                    {
                        cmd.Connection = connection;
                        cmd.CommandText = @"
                            
                            SELECT Node.ID, Node.Type FROM Node
                            WHERE Node.DiagramId = 21;

                            SELECT Node.ID ,Compartment.Type 'Text', Compartment.Value FROM Node
                            LEFT JOIN Compartment ON Node.ID = Compartment.ElementId
                            WHERE Node.DiagramId = 21;

                            SELECT Edge.ID, Edge.StartNodeId, Edge.EndNodeId, Compartment.Value  FROM Edge
                            Join Compartment ON Edge.ID = Compartment.ElementId
                            WHERE  Edge.DiagramId = 21 AND Edge.Type like 'Pareja' AND Compartment.Type like 'Name' ;
                            
                          
                            
                            
                            ";
                        adapter.SelectCommand = cmd;
                        adapter.Fill(graphInformation);
                        graphInformation.Tables[0].TableName = "Node";
                        graphInformation.Tables[1].TableName = "Compartment";
                        graphInformation.Tables[2].TableName = "Edge";

                        graphInformation.Tables[0].PrimaryKey = new DataColumn[] { graphInformation.Tables[0].Columns["ID"] };
                        //TODO: pārliec ka apvienošanai ir vismaz 1 atribūts
                        graphInformation.Tables[1].PrimaryKey = new DataColumn[] { graphInformation.Tables[1].Columns["ID"], graphInformation.Tables[1].Columns["Text"]  };
                        graphInformation.Tables[2].PrimaryKey = new DataColumn[] { graphInformation.Tables[2].Columns["ID"], graphInformation.Tables[2].Columns["StartNodeId"], graphInformation.Tables[2].Columns["EndNodeId"] };



                    }
                }
            }

            var graph = new  Graph();
            
            foreach (DataRow row in graphInformation.Tables[0].Rows )
            {
                if (row.ItemArray[1].ToString() == "Sakums")
                {
                    graph.AddNode((long)row.ItemArray[0], Type.Sakums, Branch.Nothing);
                }
                else if (row.ItemArray[1].ToString() == "Beigas")
                {
                    graph.AddNode((long)row.ItemArray[0], Type.Beigas, Branch.Nothing);
                }
                else if (row.ItemArray[1].ToString() == "Apvienosana")
                {
                    graph.AddNode((long)row.ItemArray[0], Type.Apvienosana, Branch.Nothing);
                }
                else if (row.ItemArray[1].ToString() == "Darbiba")
                {
                   
                    graph.AddNode((long)row.ItemArray[0], Type.Darbiba, graphInformation.Tables[1].Rows.Find(new object[] { row.ItemArray[0], "Name" }).ItemArray[2].ToString(), 
                        Branch.Nothing);
                }

                else if (row.ItemArray[1].ToString() == "Zarosanas")
                {
                    graph.AddNode((long)row.ItemArray[0], Type.Zarosanas,Branch.Nothing,
                        graphInformation.Tables[1].Rows.Find(new object[] { row.ItemArray[0], "Informal" }).ItemArray[2].ToString(),
                        graphInformation.Tables[1].Rows.Find(new object[] { row.ItemArray[0], "Formal" }).ItemArray[2].ToString());
                }

            }
          

            return graph;
        }




   
    }
}
