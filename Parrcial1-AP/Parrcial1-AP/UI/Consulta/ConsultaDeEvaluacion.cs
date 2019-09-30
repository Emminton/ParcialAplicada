using Parrcial1_AP.Entidades;
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

namespace Parrcial1_AP.UI.Consulta
{
    public partial class ConsultaDeEvaluacion : Form
    {
        public ConsultaDeEvaluacion()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {

            List<Estudiantes> lista = new List<Estudiantes>();

            if (CriteriotextBox1.Text.Trim().Length > 0)
            {
                switch (FiltrocomboBox1.SelectedIndex)
                {
                    case 0:
                        lista = EstudianteBLL.GetList(p => true);
                        break;
                    case 1:
                        try
                        {
                            int ID = Convert.ToInt32(CriteriotextBox1.Text);
                            lista = EstudianteBLL.GetList(p => p.IDestudiante == ID);
                        }
                        catch (Exception)
                        {

                            MessageBox.Show("El criterio para el ID debe ser numerico");
                        }
                        break;
                    case 2:
                        lista = EstudianteBLL.GetList(p => p.nombre.Contains(CriteriotextBox1.Text));
                        break;
                    default:
                        MessageBox.Show("Esta opción no existe");
                        break;
                }

                lista = lista.Where(p => p.fecha.Date >= DesdedateTimePicker2.Value.Date
                && p.fecha.Date <= HastadateTimePicker1.Value.Date).ToList();

            }
            else
            {
                lista = EstudianteBLL.GetList(p => true);
            }

            ConsultardataGridView1.DataSource = null;
            ConsultardataGridView1.DataSource = lista;
        }
    }
    
}
