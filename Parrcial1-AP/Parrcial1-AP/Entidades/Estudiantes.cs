using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Parrcial1_AP.Entidades
{
    public class Estudiantes
    {
      
        [Key]

        public int IDestudiante { get; set; }
        public DateTime fecha { get; set; }
        public string nombre { get; set; }
        public string  Pronostico{ get; set; }
        public decimal valor { get; set; }
        public decimal obtenido { get; set; }

        public decimal perdido{ get; set; }

        public Estudiantes(int destudiante, DateTime fecha, string nombre, decimal calificacion, int valor, decimal tarea, decimal parcial)
        {
            IDestudiante = destudiante;
            this.fecha = fecha;
            this.nombre = nombre ?? throw new ArgumentNullException(nameof(nombre));
            this.Pronostico = Pronostico ?? throw new ArgumentNullException(nameof(Pronostico));
            this.valor = valor;
            this.obtenido = tarea;
            this.perdido = parcial;
        }

        public Estudiantes()
        {
        }
    }

}
