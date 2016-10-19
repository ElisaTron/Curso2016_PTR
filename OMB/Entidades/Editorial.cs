using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
   public class Editorial
    {

        public int ID_Editorial { get; set; }
        public string Nombre { get; set; }
        public string Domicilio { get; set; }
        public string AmpliacionDomicilio { get; set; }
        
        public virtual Localidad localidad { get; set; }
        public virtual HashSet<Libro> Libros { get; set; }

        public Editorial()
        {
            Libros = new HashSet<Libro>();
        }
    }
}
