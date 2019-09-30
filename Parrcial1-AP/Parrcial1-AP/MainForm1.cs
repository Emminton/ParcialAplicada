using Parrcial1_AP.UI.Registro;
using Parrcial1_AP.UI.Consulta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parrcial1_AP
{
    public partial class MainForm1 : Form
    {
        public MainForm1()
        {
            InitializeComponent();
        }

        private void EvaluarEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroEvaluancion estudiante = new  RegistroEvaluancion();
            estudiante.Show();
        }

        private void EvaluarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultaDeEvaluacion evaluacion = new ConsultaDeEvaluacion();
            evaluacion.Show();
        }
    }
}
