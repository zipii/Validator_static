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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbtnSQL = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbtnSQLdb = new System.Windows.Forms.RadioButton();
            this.rbtnSQLite = new System.Windows.Forms.RadioButton();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.txtGraphDiagram = new System.Windows.Forms.TextBox();
            this.btnGraphDb = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.rbtnC.Location = new System.Drawing.Point(18, 3);
            this.rbtnC.Name = "rbtnC";
            this.rbtnC.Size = new System.Drawing.Size(63, 29);
            this.rbtnC.TabIndex = 1;
            this.rbtnC.TabStop = true;
            this.rbtnC.Text = "C#";
            this.rbtnC.UseVisualStyleBackColor = true;
            this.rbtnC.CheckedChanged += new System.EventHandler(this.Code_Type_Changed);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbtnSQL);
            this.panel1.Controls.Add(this.rbtnC);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 2;
            // 
            // rbtnSQL
            // 
            this.rbtnSQL.AutoSize = true;
            this.rbtnSQL.Location = new System.Drawing.Point(18, 47);
            this.rbtnSQL.Name = "rbtnSQL";
            this.rbtnSQL.Size = new System.Drawing.Size(78, 29);
            this.rbtnSQL.TabIndex = 2;
            this.rbtnSQL.Text = "SQL";
            this.rbtnSQL.UseVisualStyleBackColor = true;
            this.rbtnSQL.CheckedChanged += new System.EventHandler(this.Code_Type_Changed);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rbtnSQLdb);
            this.panel2.Controls.Add(this.rbtnSQLite);
            this.panel2.Location = new System.Drawing.Point(236, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 100);
            this.panel2.TabIndex = 3;
            // 
            // rbtnSQLdb
            // 
            this.rbtnSQLdb.AutoSize = true;
            this.rbtnSQLdb.Location = new System.Drawing.Point(12, 47);
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
            this.rbtnSQLite.Location = new System.Drawing.Point(12, 3);
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
            this.txtGraphDiagram.Location = new System.Drawing.Point(12, 135);
            this.txtGraphDiagram.Name = "txtGraphDiagram";
            this.txtGraphDiagram.ReadOnly = true;
            this.txtGraphDiagram.Size = new System.Drawing.Size(424, 29);
            this.txtGraphDiagram.TabIndex = 4;
            // 
            // btnGraphDb
            // 
            this.btnGraphDb.Location = new System.Drawing.Point(470, 135);
            this.btnGraphDb.Name = "btnGraphDb";
            this.btnGraphDb.Size = new System.Drawing.Size(93, 35);
            this.btnGraphDb.TabIndex = 5;
            this.btnGraphDb.Text = "pārlūkot";
            this.btnGraphDb.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnGraphDb.UseVisualStyleBackColor = true;
            this.btnGraphDb.Click += new System.EventHandler(this.btnGraphDb_Click);
            // 
            // Validator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 625);
            this.Controls.Add(this.btnGraphDb);
            this.Controls.Add(this.txtGraphDiagram);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Name = "Validator";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton rbtnC;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton rbtnSQL;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbtnSQLdb;
        private System.Windows.Forms.RadioButton rbtnSQLite;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.TextBox txtGraphDiagram;
        private System.Windows.Forms.Button btnGraphDb;
    }
}

