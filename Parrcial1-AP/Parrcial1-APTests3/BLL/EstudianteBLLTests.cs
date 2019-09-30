using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parrcial1_AP.BLL;
using Parrcial1_AP.DAL;
using Parrcial1_AP.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrcial1_AP.BLL.Tests
{
    [TestClass()]
    public class EstudianteBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Estudiantes estu = new Estudiantes();          

            estu.IDestudiante = 0;
            estu.fecha = DateTime.Now;
            estu.nombre = "yo mismo";
            estu.Pronostico = "Continuar";           
            estu.valor = 31;
            estu.obtenido = 20;
            estu.obtenido = 11;
            
            bool paso = EstudianteBLL.Guardar(estu);
            Assert.AreEqual(paso,true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Estudiantes estu1 = new Estudiantes();

            estu1.IDestudiante = 1;
            estu1.fecha = DateTime.Now;
            estu1.nombre = "yo mismo";
            estu1.Pronostico = " dhhthsrt";
            estu1.valor = 31;
            estu1.obtenido = 20;
            estu1.obtenido = 11;
            
            bool paso1 = EstudianteBLL.Modificar(estu1);
            Assert.AreEqual(paso1, true);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            int id = 1;
            bool  paso;
            Contexto db = new Contexto();
            paso = EstudianteBLL.Eliminar(id);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Estudiantes estu = new Estudiantes();

            estu = EstudianteBLL.Buscar(1);

            Assert.AreEqual(estu,estu);
        }

        [TestMethod()]
        public void GetListTest()
        {
             
          var lista = new List<Estudiantes>();
            Assert.IsNotNull(lista);
        }
    }
}