using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrcial1_AP.Entidades
{
    public class Estudiantes
    {
        [key]

        public int IDestudiante { get; set; }
        public DateTime fecha { get; set; }
        public string nombre { get; set; }
        public decimal  calificacion{ get; set; }
        public int valor { get; set; }
        public decimal logrado { get; set; }

        public decimal perdido{ get; set; }

        public Estudiantes(int destudiante, DateTimeKind fecha, string nombre, decimal calificacion, int valor, decimal logrado, decimal perdido)
        {
            IDestudiante = destudiante;
            this.fecha = fecha;
            this.nombre = nombre;
            this.calificacion = calificacion;
            this.valor = valor;
            this.logrado = logrado;
            this.perdido = perdido;
        }

        public Estudiantes()
        {
        }
    }

}
