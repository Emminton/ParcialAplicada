using Parrcial1_AP.BLL;
using Parrcial1_AP.Entidades;
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
    public partial class RegistroEvaluancion : Form
    {
        public RegistroEvaluancion()
        {
            InitializeComponent();
        }

        private void Limpiar()
        {
            IDnumericUpDown1.Value = 1;
            FechadateTimePicker1.Value = DateTime.Now;
            NombretextBox1.Text = string.Empty;
            PronosticocomboBox1.Text = string.Empty;
            ValortextBox1.Text = string.Empty;
            ObtenidotextBox2.Text = string.Empty;
            PerdidotextBox3.Text = string.Empty;         
            
            MyErrorProvider1.Clear();
            
        }

        private void LlenarCampo(Estudiantes estudiante)
        {

            IDnumericUpDown1.Value = estudiante.IDestudiante;
            FechadateTimePicker1.Value = estudiante.fecha;
            NombretextBox1.Text = estudiante.nombre;
            PronosticocomboBox1.Text = estudiante.Pronostico.ToString();           
            ValortextBox1.Text = estudiante.valor.ToString();
            ObtenidotextBox2.Text = estudiante.obtenido.ToString();
            PerdidotextBox3.Text = estudiante.perdido.ToString();           
                            
        }

        private Estudiantes LLenaClase()
        {

            Estudiantes estudiante = new Estudiantes();
            estudiante.IDestudiante = Convert.ToInt32(IDnumericUpDown1.Value);
            estudiante.fecha = FechadateTimePicker1.Value;
            estudiante.nombre = NombretextBox1.Text;
            estudiante.valor = Convert.ToDecimal(ValortextBox1);
            estudiante.obtenido = Convert.ToDecimal(ObtenidotextBox2);
            estudiante.perdido = Convert.ToDecimal(PerdidotextBox3);
           
            if (PronosticocomboBox1.SelectedIndex == 2)
            {
                estudiante.Pronostico = "Continuar";
            }
            if (PronosticocomboBox1.SelectedIndex == 1)
            {
                estudiante.Pronostico = "Riesgo";
            }
            if (PronosticocomboBox1.SelectedIndex == 0)
            {
                estudiante.Pronostico = "Retirar";
            }

            return estudiante;
        }     
        private bool Existe()
        {
            Estudiantes estudiantes = EstudianteBLL.Buscar((int)IDnumericUpDown1.Value);
            return (estudiantes != null);
        }

        private void Nuevobutton3_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Guardarbutton1_Click(object sender, EventArgs e)
        {
            Estudiantes estudiante = new Estudiantes();
            bool paso = false;
          

            if (!Validar())
                return;

            try
            {
                estudiante = LLenaClase();

                if (IDnumericUpDown1.Value == 0)
                {
                    paso = EstudianteBLL.Guardar(estudiante);
                }
                else
                {
                    if (!Existe())
                    {
                        MessageBox.Show("No se puede modificar porque no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    paso = EstudianteBLL.Modificar(estudiante);
                }

            }
            catch (Exception)
            {
                throw;
            }

            if (paso)
            {
                Limpiar();
                MessageBox.Show("Guardado con exito!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al guardar!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Eliminarbutton2_Click(object sender, EventArgs e)
        {          
            int Id;
            int.TryParse(IDnumericUpDown1.Value.ToString(), out Id);

            try
            {
                if (EstudianteBLL.Buscar(Id) != null)
                {
                    if (EstudianteBLL.Eliminar(Id))
                    {
                        MessageBox.Show("Eliminada Correctamente", "Eliminada", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No se puede eliminar porque no existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void Buscarbutton1_Click(object sender, EventArgs e)
        {
            int id;           
            int.TryParse(IDnumericUpDown1.Text, out id);

            Limpiar();
            try
            {
              Estudiantes  estudiante = EstudianteBLL.Buscar(id);

                if (estudiante != null)
                {

                    LlenarCampo(estudiante);

                }
                else
                {
                    MessageBox.Show("Evaluacion no encontrada.", "error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }

        private bool Validar()
        {
            bool realizado = true;

            if (string.IsNullOrWhiteSpace(NombretextBox1.Text))
            {
                MyErrorProvider1.SetError(NombretextBox1, "El campo Estudiante no puede estar vacio");
                NombretextBox1.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(ValortextBox1.Text) || Convert.ToDecimal(ValortextBox1.Text) < 0)
            {
                MyErrorProvider1.SetError(ValortextBox1, "El campo Valor no puede estar vacio \n El campo obtenido no puede ser menor que 0");
                ValortextBox1.Focus();
                realizado = false;
            }
            if (string.IsNullOrWhiteSpace(ObtenidotextBox2.Text) || Convert.ToDecimal(ObtenidotextBox2.Text) < 0)
            {
                MyErrorProvider1.SetError(ObtenidotextBox2, "El campo Obtenido no puede estar vacio \n El campo obtenido no puede ser menor que 0");
                ObtenidotextBox2.Focus();
                realizado = false;
            }

            return realizado;
        }

        private void ValortextBox1_TextChanged(object sender, EventArgs e)
        {
            decimal valor = 0, obtenido = 0, perdido = 0;

            if (!string.IsNullOrWhiteSpace(ValortextBox1.Text))
            {
                valor = decimal.Parse(ValortextBox1.Text);
            }
            if (!string.IsNullOrWhiteSpace(ObtenidotextBox2.Text))
            {
                obtenido = decimal.Parse(ObtenidotextBox2.Text);
            }

            perdido = valor - obtenido;          
 
             PerdidotextBox3.Text = perdido.ToString();

            if (perdido >= 25 && perdido <= 30)
            {
                PronosticocomboBox1.SelectedIndex = 1;
            }
            if (perdido < 25)
            {
                PronosticocomboBox1.SelectedIndex = 0;
            }
            
            if (perdido > 30)
            {
                PronosticocomboBox1.SelectedIndex = 2;
            }
                     
        }

        private void ObtenidotextBox2_TextChanged(object sender, EventArgs e)
        {
           
            
            decimal valor = 0, obtenido = 0, perdido = 0;

            if (!string.IsNullOrWhiteSpace(ValortextBox1.Text) && ObtenidotextBox2.Text != "-")
            {
                valor = decimal.Parse(ValortextBox1.Text);
            }
            if (!string.IsNullOrWhiteSpace(ObtenidotextBox2.Text) && ObtenidotextBox2.Text != "-")
            {
                obtenido = decimal.Parse(ObtenidotextBox2.Text);
            }

            perdido = valor - obtenido;
       
            PronosticocomboBox1.Text = perdido.ToString();
            if (perdido >= 25 && perdido <= 30)
            {
                PronosticocomboBox1.SelectedIndex = 1;
            }
            if (perdido < 25)
            {
                PronosticocomboBox1.SelectedIndex = 0;
            }
            if (perdido > 30)
            {
                PronosticocomboBox1.SelectedIndex = 2;
            }

        }     
    }
}
