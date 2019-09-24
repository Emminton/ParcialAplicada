using Parrcial1_AP.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parrcial1_AP.UI.Registro
{
    public partial class Registro_de_evaluancion : Form
    {
        public Registro_de_evaluancion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown1.Value = 0;
            NombretextBox1.Text = string.Empty;
            FechamaskedTextBox1.Value = DateTime.Now;
            ParcialtextBox3.Text = string.Empty;
            TareatextBox2.Text = string.Empty;
            ValortextBox1.Text = string.Empty;
            MyErrorProvider1.Clear();

        }

        private void LlenarCampo(Estudiante estudiante)
        {

            IDnumericUpDown1.Value = estudiante.IDestudiante;
            NombretextBox1.Text = estudiante.nombre;
            FechamaskedTextBox1.Text = estudiante.fecha;
            ParcialtextBox3.Text = estudiante.perdido;
            ValortextBox1.Text = estudiante.valor;
            TareatextBox2.Text = estudiante.tarea;


        }

        private Estudiante LLenaClase()
        {
            Estudiante estudiante = new Estudiante();
            estudiante.IDestudiante = Convert.ToInt32(IDnumericUpDown1.Value);
            estudiante.nombre = NombretextBox1.Text;
            estudiante.valor = Convert.ToDecimal(ValortextBox1.Text);
            estudiante.perdido = Convert.ToDecimal(ParcialtextBox3);
            estudiante.tarea = Convert.ToDecimal(TareatextBox2);
            return estudiante;
        }

        private void Nuevobutton3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            int id;
            Estudiante estudiante = new Estudiante();
            int.TryParse(IDnumericUpDown1.Text, out id);

            Limpiar();

            estudiante = EstudianteBLL.Buscar(id);

            if (estudiante != null)
            {
                MessageBox.Show("Estudiante encontrado.");
                LlenarCampo(estudiante);

            }
            else
            {
                MessageBox.Show("Estudiante no encontrado.");
            }

        }

        private void Guardarbutton1_Click(object sender, EventArgs e)
        {
            Estudiante estudiante;
            bool paso = false;

            if (!Validar())
                return;
            estudiante = LLenaClase();

            //determina si es guardar oh modificar

            if (IDnumericUpDown1.Value == 0)
                paso = EstudianteBLL.Guardar(estudiante);

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado!!", "Exito.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("No fue posible guardar!!", "fallo.", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Eliminarbutton2_Click(object sender, EventArgs e)
        {

            MyErrorProvider1.Clear();

            int id;
            int.TryParse(IDnumericUpDown1.Text, out id);

            Limpiar();

            if (EstudianteBLL.Eliminar(id))
                MessageBox.Show("Eliminado", " Con Exito..", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MyErrorProvider1.SetError(IDnumericUpDown1, "No se puede eliminar un estudiante que no existe");
        }

        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider1.Clear();

            if (string.IsNullOrWhiteSpace(IDnumericUpDown1.Text))
            {
                MyErrorProvider1.SetError(IDnumericUpDown1, "El campode del ID no puede estar vacio...");
                IDnumericUpDown1.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(NombretextBox1.Text))
            {
                MyErrorProvider1.SetError(NombretextBox1, "El campo de estudiamtete no puede estar vacio...");
                NombretextBox1.Focus();
                paso = false;
            }

            if (string.IsNullOrWhiteSpace(FechamaskedTextBox1.Text))
            {
                MyErrorProvider1.SetError(FechamaskedTextBox1, "El campo de estudiamtete no puede estar vacio...");
                FechamaskedTextBox1.Focus();
                paso = false;
            }


            if (string.IsNullOrWhiteSpace(ValortextBox1.Text))
            {
                MyErrorProvider1.SetError(ValortextBox1, "El campo valor no puede estar vacio...");
                ValortextBox1.Focus();
                paso = false;
            }

            return paso;

        }

    }
}
