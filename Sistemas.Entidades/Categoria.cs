using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistemas.Entidades
{
    public class Categoria
    {
        public int Idcategoria { get; set; }

        public string Nombre { get; set; }
        
        public string Descripcion { get; set; }
        
        public bool Estado { get; set; }
    }
}
