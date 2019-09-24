using Parrcial1_AP.BLL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parrcial1_AP.DAL
{
    public class Contexto : DbContext
    {  
            public DbSet<Estudiante> estudiante { get; set; }
            public Contexto() : base("ConStr")
            {

            }
    }
    
}
