namespace Parrcial1_AP.UI.Registro
{
    partial class Registro_de_evaluancion
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
            this.components = new System.ComponentModel.Container();
            this.IDnumericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.FechamaskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombretextBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Guardarbutton1 = new System.Windows.Forms.Button();
            this.Eliminarbutton2 = new System.Windows.Forms.Button();
            this.Nuevobutton3 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.ValortextBox1 = new System.Windows.Forms.TextBox();
            this.TareatextBox2 = new System.Windows.Forms.TextBox();
            this.ParcialtextBox3 = new System.Windows.Forms.TextBox();
            this.Buscarbutton1 = new System.Windows.Forms.Button();
            this.MyErrorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDnumericUpDown1
            // 
            this.IDnumericUpDown1.Location = new System.Drawing.Point(102, 13);
            this.IDnumericUpDown1.Name = "IDnumericUpDown1";
            this.IDnumericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.IDnumericUpDown1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID:";
            // 
            // FechamaskedTextBox1
            // 
            this.FechamaskedTextBox1.Location = new System.Drawing.Point(303, 12);
            this.FechamaskedTextBox1.Mask = "00/00/0000";
            this.FechamaskedTextBox1.Name = "FechamaskedTextBox1";
            this.FechamaskedTextBox1.Size = new System.Drawing.Size(74, 20);
            this.FechamaskedTextBox1.TabIndex = 2;
            this.FechamaskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(257, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Estudiante:";
            // 
            // NombretextBox1
            // 
            this.NombretextBox1.Location = new System.Drawing.Point(97, 68);
            this.NombretextBox1.Name = "NombretextBox1";
            this.NombretextBox1.Size = new System.Drawing.Size(230, 20);
            this.NombretextBox1.TabIndex = 5;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(97, 238);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(234, 21);
            this.comboBox1.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Pronostico:";
            // 
            // Guardarbutton1
            // 
            this.Guardarbutton1.Location = new System.Drawing.Point(199, 310);
            this.Guardarbutton1.Name = "Guardarbutton1";
            this.Guardarbutton1.Size = new System.Drawing.Size(71, 39);
            this.Guardarbutton1.TabIndex = 8;
            this.Guardarbutton1.Text = "Guardar";
            this.Guardarbutton1.UseVisualStyleBackColor = true;
            this.Guardarbutton1.Click += new System.EventHandler(this.Guardarbutton1_Click);
            // 
            // Eliminarbutton2
            // 
            this.Eliminarbutton2.Location = new System.Drawing.Point(308, 310);
            this.Eliminarbutton2.Name = "Eliminarbutton2";
            this.Eliminarbutton2.Size = new System.Drawing.Size(78, 39);
            this.Eliminarbutton2.TabIndex = 9;
            this.Eliminarbutton2.Text = "Eliminar";
            this.Eliminarbutton2.UseVisualStyleBackColor = true;
            this.Eliminarbutton2.Click += new System.EventHandler(this.Eliminarbutton2_Click);
            // 
            // Nuevobutton3
            // 
            this.Nuevobutton3.Location = new System.Drawing.Point(79, 310);
            this.Nuevobutton3.Name = "Nuevobutton3";
            this.Nuevobutton3.Size = new System.Drawing.Size(74, 39);
            this.Nuevobutton3.TabIndex = 10;
            this.Nuevobutton3.Text = "Nuevo";
            this.Nuevobutton3.UseVisualStyleBackColor = true;
            this.Nuevobutton3.Click += new System.EventHandler(this.Nuevobutton3_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 139);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Calificacion Tares y Parcial:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 161);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Valor:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(182, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Tareas";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(292, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Parcial";
            // 
            // ValortextBox1
            // 
            this.ValortextBox1.Location = new System.Drawing.Point(97, 188);
            this.ValortextBox1.Name = "ValortextBox1";
            this.ValortextBox1.Size = new System.Drawing.Size(45, 20);
            this.ValortextBox1.TabIndex = 18;
            // 
            // TareatextBox2
            // 
            this.TareatextBox2.Location = new System.Drawing.Point(183, 188);
            this.TareatextBox2.Name = "TareatextBox2";
            this.TareatextBox2.Size = new System.Drawing.Size(53, 20);
            this.TareatextBox2.TabIndex = 19;
            // 
            // ParcialtextBox3
            // 
            this.ParcialtextBox3.Location = new System.Drawing.Point(276, 188);
            this.ParcialtextBox3.Name = "ParcialtextBox3";
            this.ParcialtextBox3.Size = new System.Drawing.Size(55, 20);
            this.ParcialtextBox3.TabIndex = 20;
            // 
            // Buscarbutton1
            // 
            this.Buscarbutton1.Location = new System.Drawing.Point(345, 61);
            this.Buscarbutton1.Name = "Buscarbutton1";
            this.Buscarbutton1.Size = new System.Drawing.Size(75, 32);
            this.Buscarbutton1.TabIndex = 21;
            this.Buscarbutton1.Text = "Buscar";
            this.Buscarbutton1.UseVisualStyleBackColor = true;
            this.Buscarbutton1.Click += new System.EventHandler(this.Buscarbutton1_Click);
            // 
            // MyErrorProvider1
            // 
            this.MyErrorProvider1.ContainerControl = this;
            // 
            // Registro_de_evaluancion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(444, 384);
            this.Controls.Add(this.Buscarbutton1);
            this.Controls.Add(this.ParcialtextBox3);
            this.Controls.Add(this.TareatextBox2);
            this.Controls.Add(this.ValortextBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Nuevobutton3);
            this.Controls.Add(this.Eliminarbutton2);
            this.Controls.Add(this.Guardarbutton1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.NombretextBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.FechamaskedTextBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDnumericUpDown1);
            this.Name = "Registro_de_evaluancion";
            this.Text = "Registro_de_evaluancion";
            ((System.ComponentModel.ISupportInitialize)(this.IDnumericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown IDnumericUpDown1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox FechamaskedTextBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombretextBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Guardarbutton1;
        private System.Windows.Forms.Button Eliminarbutton2;
        private System.Windows.Forms.Button Nuevobutton3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox ValortextBox1;
        private System.Windows.Forms.TextBox TareatextBox2;
        private System.Windows.Forms.TextBox ParcialtextBox3;
        private System.Windows.Forms.Button Buscarbutton1;
        private System.Windows.Forms.ErrorProvider MyErrorProvider1;
    }
}