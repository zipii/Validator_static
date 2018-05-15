namespace Validator_static
{
    partial class Validator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.rbtnC = new System.Windows.Forms.RadioButton();
            this.rbtnSQL = new System.Windows.Forms.RadioButton();
            this.rbtnSQLdb = new System.Windows.Forms.RadioButton();
            this.rbtnSQLite = new System.Windows.Forms.RadioButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.txtGraphDiagram = new System.Windows.Forms.TextBox();
            this.btnGraphDb = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 531);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1200, 94);
            this.button1.TabIndex = 0;
            this.button1.Text = "Nospied";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button_Click);
            // 
            // rbtnC
            // 
            this.rbtnC.AutoSize = true;
            this.rbtnC.Checked = true;
            this.rbtnC.Location = new System.Drawing.Point(15, 28);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(63, 29);
            this.rbtnC.TabIndex = 1;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "C#";
            this.rbtnC.UseVisualStyleBackColor = true;
            this.rbtnC.CheckedChanged += new System.EventHandler(this.Code_Type_Changed);
            // 
            // rbtnSQL
            // 
            this.rbtnSQL.AutoSize = true;
            this.rbtnSQL.Location = new System.Drawing.Point(15, 71);
            this.rbtnSQL.Name = "rbtnSQL";
            this.rbtnSQL.Size = new System.Drawing.Size(78, 29);
            this.rbtnSQL.TabIndex = 2;
            this.rbtnSQL.Text = "SQL";
            this.rbtnSQL.UseVisualStyleBackColor = true;
            this.rbtnSQL.CheckedChanged += new System.EventHandler(this.Code_Type_Changed);
            // 
            // rbtnSQLdb
            // 
            this.rbtnSQLdb.AutoSize = true;
            this.rbtnSQLdb.Location = new System.Drawing.Point(6, 67);
            this.rbtnSQLdb.Name = "rbtnSQLdb";
            this.rbtnSQLdb.Size = new System.Drawing.Size(78, 29);
            this.rbtnSQLdb.TabIndex = 5;
            this.rbtnSQLdb.TabStop = true;
            this.rbtnSQLdb.Text = "SQL";
            this.rbtnSQLdb.UseVisualStyleBackColor = true;
            this.rbtnSQLdb.CheckedChanged += new System.EventHandler(this.Database_Changed);
            // 
            // rbtnSQLite
            // 
            this.rbtnSQLite.AutoSize = true;
            this.rbtnSQLite.Checked = true;
            this.rbtnSQLite.Location = new System.Drawing.Point(6, 24);
            this.rbtnSQLite.Name = "rbtnSQLite";
            this.rbtnSQLite.Size = new System.Drawing.Size(98, 29);
            this.rbtnSQLite.TabIndex = 4;
            this.rbtnSQLite.TabStop = true;
            this.rbtnSQLite.Text = "SQLite";
            this.rbtnSQLite.UseVisualStyleBackColor = true;
            this.rbtnSQLite.CheckedChanged += new System.EventHandler(this.Database_Changed);
            // 
            // openFile
            // 
            this.openFile.FileOk += new System.ComponentModel.CancelEventHandler(this.Choose_Graph_Diagram);
            // 
            // txtGraphDiagram
            // 
            this.txtGraphDiagram.Location = new System.Drawing.Point(6, 39);
            this.txtGraphDiagram.Name = "txtGraphDiagram";
            this.txtGraphDiagram.ReadOnly = true;
            this.txtGraphDiagram.Size = new System.Drawing.Size(424, 29);
            this.txtGraphDiagram.TabIndex = 4;
            // 
            // btnGraphDb
            // 
            this.btnGraphDb.Location = new System.Drawing.Point(463, 33);
            this.btnGraphDb.Name = "btnGraphDb";
            this.btnGraphDb.Size = new System.Drawing.Size(93, 35);
            this.btnGraphDb.TabIndex = 5;
            this.btnGraphDb.Text = "pārlūkot";
            this.btnGraphDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGraphDb.UseVisualStyleBackColor = true;
            this.btnGraphDb.Click += new System.EventHandler(this.btnGraphDb_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtGraphDiagram);
            this.groupBox1.Controls.Add(this.btnGraphDb);
            this.groupBox1.Location = new System.Drawing.Point(12, 141);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Grafa fails";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rbtnC);
            this.groupBox2.Controls.Add(this.rbtnSQL);
            this.groupBox2.Location = new System.Drawing.Point(12, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 123);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Komandu veids";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rbtnSQLite);
            this.groupBox3.Controls.Add(this.rbtnSQLdb);
            this.groupBox3.Location = new System.Drawing.Point(242, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 123);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datu avota tips";
            // 
            // Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 625);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Name = "Validator";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.RadioButton rbtnSQL;
        private System.Windows.Forms.RadioButton rbtnSQLdb;
        private System.Windows.Forms.RadioButton rbtnSQLite;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox txtGraphDiagram;
        private System.Windows.Forms.Button btnGraphDb;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

