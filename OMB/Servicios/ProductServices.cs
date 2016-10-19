using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Data;

namespace Servicios
{
  /// <summary>
  /// Agrupamos todos los servicios relacionados con Productos: Libros, Categorias, Autores, etc...
  /// </summary>
  public class ProductServices
  {

        public List<Editorial> Get_Editoriales()
        {
            OMBContext ctx = OMBContext.DB;
            List<Editorial> lEdit = new List<Editorial>();  
            lEdit = ctx.Editoriales.ToList();
            return lEdit; 
        } 

  }
}
