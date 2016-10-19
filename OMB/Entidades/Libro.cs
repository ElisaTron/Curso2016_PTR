using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;


namespace Entidades
{
    public class Libro
    {
        public int ID_Libro { get; set; }
        public string ISBN { get; set; }
        public string ISBN10 { get; set; }
        public string Titulo { get; set; }
        public string Subtitulo { get; set; }
        public DateTime FechaPublicacion { get; set; }
        public int Paginas { get; set; }
        public string DatosEnvio { get; set; }
        public byte[] Portada { get; set; }
        public virtual Editorial Editorial { get; set; }

        public Libro()
        {
           // ID_Libro = Guid.NewGuid();
            
        }
    }
}
