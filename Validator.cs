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
using Microsoft.CSharp;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Reflection;

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
            // Glabājas virsotnes koka apstaigāšanai
            Stack<Node> nodeStack = new Stack<Node>();
            //Glabājam zarošanos ceļu skaitu, lai zinātu, kurā brīdī skatīties apvienošanas mezglu
            Stack<int> branchCountStack = new Stack<int>();
            //Glabājam zarošanās virsotnes, lai zinātu zarošanās noacījumus
            Stack<ZarosanasNode> branchNode = new Stack<ZarosanasNode>();
            int branchCounter = 0;
            StringBuilder code = new StringBuilder();

            // Iegūst sākuma virsotni un ieliek to iekš steka 
            Node node = graph.getNodeByType(Type.Sakums);
            // Glabāsim aktuālo zarošanās virsotni
            ZarosanasNode zarosanasNode = null;

            nodeStack.Push(node);

          

            //Koda sākumā jābūt jau nodefinētām lietām
            code.AppendLine("using System; using System.Text.RegularExpressions; using System.Diagnostics;");
            code.AppendLine(@"public  class Valid {
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

                 private static TraceSource _source = new TraceSource(""quality"");

                 public void Validator () 
                 {
                     _source.TraceEvent(TraceEventType.Verbose, 0, ""Sākums "" + id.ToString());");

            //Ejam caur grafu un būvējam validatora kodu
            while (nodeStack.Count != 0)
            {
                node = nodeStack.Pop();
               
               
                switch (node.type)
                {
                    case Type.Sakums:
                        break;
                    case Type.Beigas:
                        break;
                    case Type.Zarosanas:

                        zarosanasNode = (ZarosanasNode)node;
                        //Pieglabājam zarošanās virsotni iekš steka
                        branchNode.Push(zarosanasNode);

                        // Vajadzētu kaimiņus likt, lai else zars būtu pēdējais, tas ir iekš steka
                        zarosanasNode.Neighbors.Reverse();
                        //zarosanasNode.Branch.Reverse();

                        //saliekam cik zari ir 
                        if (branchCounter != 0)
                        {
                            // Nozīmē, ka ir izveidojusies jauna zarošanās, kā rezultātā, vecā vērtība jāpieglabā
                            branchCountStack.Push(branchCounter);

                            
                        }
                        // Piešķir, lai zinātu, cik zariem jāiet cauri, lai drīkstētu apskatīt apvienošanas virsotnes bērnus/kaimiņus
                        branchCounter = zarosanasNode.Neighbors.Count;

                        //Atkarībā no bērnu skaita var zināt, vai ir vairāki zari, vai tikai divi (attiecīgi true un false)
                         if (zarosanasNode.Neighbors.Count == 2 )
                        {
                            code.AppendLine("//" +zarosanasNode.informal);
                            code.AppendLine(@"if(" + zarosanasNode.formal + ")")
                                .AppendLine(@"{");
                        }
                         else if (zarosanasNode.Neighbors.Count > 2)
                        {
                            code.AppendLine("//" +zarosanasNode.informal);
                            code.AppendLine(@"if(" + zarosanasNode.formal +"" + zarosanasNode.Branch[0]+")")
                                .AppendLine(@"{");

                            // Nometam izmantoto branch nosacījumu
                            zarosanasNode.Branch.RemoveAt(0);
                        }

                        break;
                    case Type.Darbiba:
                        DarbibaNode darbibaNode = (DarbibaNode)node;
                        // Darbības, kas jāizdara
                        code.AppendLine(@"" + darbibaNode.name + ";");
                        break;
                    case Type.Apvienosana:
                        // Ja vēl ir nepaskatīti zari jāturpina darbība
                          if (branchCounter != 0)
                        {
                            branchCounter--;
                            code.AppendLine(@"} ");
                            // Nodrošina, ka nekas jauns netiek pievienots, ja apskatīti visi zari
                            if (branchCounter == 0)
                            {
                                break;
                            }

                            // apskatām zarošanās node, lai zinātu, kas pa nosacījumu jāģenerē tālāk
                           else if (zarosanasNode.Neighbors.Count == 2)
                            {
                                
                                code.AppendLine(@"else")
                                    .AppendLine(@"{");
                            }
                            else if (zarosanasNode.Neighbors.Count > 2)
                            {
                                // Ja nav palicis tikai else zars, tad jāveido else if
                                if (zarosanasNode.Branch.Count > 1)
                                {
                                   
                                    code.AppendLine(@"else if(" + zarosanasNode.formal + "" + zarosanasNode.Branch[0] + ")")
                                        .AppendLine(@"{");
                                }
                                else
                                {
                                 
                                    code.AppendLine(@"else")
                                        .AppendLine(@"{");
                                }
                               

                                // Nometam izmantoto branch nosacījumu
                                zarosanasNode.Branch.RemoveAt(0);
                            }

                            continue;
                        }
                          // Ja visi zari ir apskatīti, bet vēl ir cita zarošanās, kas ir virszarošanās, kas notika, tad jāiet atpakaļ uz to
                        else if (branchCounter == 0 && branchCountStack.Count > 0 )
                        {
                            branchCounter = branchCountStack.Pop();
                            branchCountStack.Pop();
                        }
                        

                        break;
                    default:
                        break;
                }

                // Saliekam virstotnes, kas būs jāapskata
                foreach (var neighbor in node.Neighbors)
                {
                    nodeStack.Push(neighbor);
                }
            }

            //Pabeidzam funkcijas un klases definīciju
            code.AppendLine(@"
                    _source.TraceEvent(TraceEventType.Verbose, 0, ""Beigas "" + id.ToString());     } 
                }");


            //TODO: Jāsataisa, lai varētu kompilēt dll
            return;

            //var compileResults = Compile(code.ToString(), "System.dll", "System.Data.dll", "System.Text.RegularExpressions.dll", "System.Diagnostics");
            //var type = compileResults.CompiledAssembly.GetType("Valid");
            //var 




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

        public static CompilerResults Compile(string code, params string[] assemblies)
        {
            var csp = new CSharpCodeProvider();
            var ccu = new CodeCompileUnit();
            var cps = new CompilerParameters();
            cps.ReferencedAssemblies.AddRange(assemblies);
            cps.GenerateInMemory = true;
            return csp.CompileAssemblyFromSource(cps, code);
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

            // Iegūst nepieciešamo informāciju grafa izveidei
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

            //Saliek grafa virsotnes
            
            foreach (DataRow row in graphInformation.Tables[0].Rows )
            {
                if (row.ItemArray[1].ToString() == "Sakums")
                {
                    graph.AddNode((long)row.ItemArray[0], Type.Sakums);
                }
                else if (row.ItemArray[1].ToString() == "Beigas")
                {
                    graph.AddNode((long)row.ItemArray[0], Type.Beigas);
                }
                else if (row.ItemArray[1].ToString() == "Apvienosana")
                {
                    graph.AddNode((long)row.ItemArray[0], Type.Apvienosana);
                }
                else if (row.ItemArray[1].ToString() == "Darbiba")
                {
                   
                    graph.AddNode((long)row.ItemArray[0], Type.Darbiba, graphInformation.Tables[1].Rows.Find(new object[] { row.ItemArray[0], "Name" }).ItemArray[2].ToString() 
                        );
                }

                else if (row.ItemArray[1].ToString() == "Zarosanas")
                {
                    graph.AddNode((long)row.ItemArray[0], Type.Zarosanas,
                        graphInformation.Tables[1].Rows.Find(new object[] { row.ItemArray[0], "Informal" }).ItemArray[2].ToString(),
                        graphInformation.Tables[1].Rows.Find(new object[] { row.ItemArray[0], "Formal" }).ItemArray[2].ToString());
                }

            }
            
            /// Saliek saites grafa virsotnēm

            foreach (Node node in graph.Nodes)
            {
                //Iegūst rindas ar pārejām, kas saistītas ar notiekto virsotni 
                var edgeRow = (from edge in graphInformation.Tables[2].AsEnumerable()
                               where  edge.Field<long>("StartNodeId") == node.ID
                               select edge).ToList();


                switch (node.type)
                {
                    case Type.Sakums:

                        graph.AddDirectedEdge(node, graph.getNodeByID(edgeRow[0].Field<long>("EndNodeId")));

                        break;
                    case Type.Beigas:

                        break;

                    case Type.Zarosanas:
                        var elseNode = node;
                        ZarosanasNode zarosanasNode = (ZarosanasNode)node;
                        foreach (var edge in edgeRow)
                        {

                            // Izdalām kas aiziet uz kuru zaru
                            if (edge.Field<String>("Value") != "" && edge.Field<long>("StartNodeId") == node.ID)
                            {
                                graph.AddDirectedEdge(node, graph.getNodeByID(edge.Field<long>("EndNodeId")));
                                // Vajag zināt kas ir uz zarošanās līnijas rakstīts
                                zarosanasNode.Branch.Add(edge.Field<String>("Value"));

                            }
                            else if (edge.Field<String>("Value") == "" && edge.Field<long>("StartNodeId") == node.ID)
                            {
                                // Nodrošina, ka else zars vienmēr ir sarakstā pēdējais

                                elseNode = graph.getNodeByID(edge.Field<long>("EndNodeId"));
                               
                            }

                           
                        }
                        // Ieliekam else zaru pašās beigās 
                        graph.AddDirectedEdge(node, elseNode);
                        //zarosanasNode = (ZarosanasNode)elseNode;
                        zarosanasNode.Branch.Add("Else");

                        break;
                    case Type.Darbiba:
                        foreach (var edge in edgeRow)
                        {

                            //if (edge.Field<String>("Value") == "OK" && edge.Field<long>("EndNodeId") == node.ID)
                            //{
                            //   // node.branch = Branch.Ok;
                            //}
                            //else if (edge.Field<String>("value") == "NO" && edge.Field<long>("EndNodeId") == node.ID)
                            //{
                            //    //node.branch = Branch.No;
                            //}
                            //else if (edge.Field<String>("value") == "" && edge.Field<long>("EndNodeId") == node.ID)
                            //{
                            //    continue;
                            //}
                            //else
                            //{
                            //    graph.AddDirectedEdge(node, graph.getNodeByID(edge.Field<long>("EndNodeId")));
                            //}
                            graph.AddDirectedEdge(node, graph.getNodeByID(edge.Field<long>("EndNodeId")));
                        }
                        break;
                    case Type.Apvienosana:
                        foreach (var edge in edgeRow)
                        {

                            //if (edge.Field<String>("Value") == "OK" && edge.Field<long>("EndNodeId") == node.ID)
                            //{
                            //    //node.branch = Branch.Ok;
                            //}
                            //else if (edge.Field<String>("value") == "NO" && edge.Field<long>("EndNodeId") == node.ID)
                            //{
                            //    //node.branch = Branch.No;
                            //}
                            //else if (edge.Field<String>("value") == "" && edge.Field<long>("EndNodeId") == node.ID)
                            //{
                            //    continue;
                            //}
                            //else
                            //{
                            //    graph.AddDirectedEdge(node, graph.getNodeByID(edge.Field<long>("EndNodeId")));
                            //}

                            graph.AddDirectedEdge(node, graph.getNodeByID(edge.Field<long>("EndNodeId")));
                        }
                        break;

                }

                Console.Write(node.ID);
            }


            return graph;
        }




   
    }
}
