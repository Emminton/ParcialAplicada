namespace Parrcial1_AP.UI.Consulta
{
    partial class ConsultaDeEvaluacion
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
            this.ConsultardataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.CriteriotextBox1 = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox1 = new System.Windows.Forms.ComboBox();
            this.HastadateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.DesdedateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.ConsultardataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // ConsultardataGridView1
            // 
            this.ConsultardataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ConsultardataGridView1.Location = new System.Drawing.Point(21, 95);
            this.ConsultardataGridView1.Name = "ConsultardataGridView1";
            this.ConsultardataGridView1.Size = new System.Drawing.Size(798, 342);
            this.ConsultardataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Desde:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(179, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(540, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Criterio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(357, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Filtro:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Consultar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // CriteriotextBox1
            // 
            this.CriteriotextBox1.Location = new System.Drawing.Point(543, 43);
            this.CriteriotextBox1.Name = "CriteriotextBox1";
            this.CriteriotextBox1.Size = new System.Drawing.Size(161, 20);
            this.CriteriotextBox1.TabIndex = 6;
            // 
            // FiltrocomboBox1
            // 
            this.FiltrocomboBox1.FormattingEnabled = true;
            this.FiltrocomboBox1.Items.AddRange(new object[] {
            "Todos",
            "ID",
            "Nombre"});
            this.FiltrocomboBox1.Location = new System.Drawing.Point(360, 42);
            this.FiltrocomboBox1.Name = "FiltrocomboBox1";
            this.FiltrocomboBox1.Size = new System.Drawing.Size(153, 21);
            this.FiltrocomboBox1.TabIndex = 7;
            // 
            // HastadateTimePicker1
            // 
            this.HastadateTimePicker1.Location = new System.Drawing.Point(182, 43);
            this.HastadateTimePicker1.Name = "HastadateTimePicker1";
            this.HastadateTimePicker1.Size = new System.Drawing.Size(148, 20);
            this.HastadateTimePicker1.TabIndex = 8;
            // 
            // DesdedateTimePicker2
            // 
            this.DesdedateTimePicker2.Location = new System.Drawing.Point(21, 43);
            this.DesdedateTimePicker2.Name = "DesdedateTimePicker2";
            this.DesdedateTimePicker2.Size = new System.Drawing.Size(139, 20);
            this.DesdedateTimePicker2.TabIndex = 9;
            // 
            // ConsultaDeEvaluacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 396);
            this.Controls.Add(this.DesdedateTimePicker2);
            this.Controls.Add(this.HastadateTimePicker1);
            this.Controls.Add(this.FiltrocomboBox1);
            this.Controls.Add(this.CriteriotextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConsultardataGridView1);
            this.Name = "ConsultaDeEvaluacion";
            this.Text = "ConsultaDeEvaluacion";
            ((System.ComponentModel.ISupportInitialize)(this.ConsultardataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView ConsultardataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox CriteriotextBox1;
        private System.Windows.Forms.ComboBox FiltrocomboBox1;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker1;
        private System.Windows.Forms.DateTimePicker DesdedateTimePicker2;
    }
}