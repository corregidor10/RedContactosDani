using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDani.Model
{
   public class Mensaje
    {
        public int IdUsuario { get; set; }
        public int IdOrigen { get; set; }
        public int IdDestino { get; set; }

        public String Asunto { get; set; }
        public String Contenido { get; set; }
        public bool Leido { get; set; }
        public DateTime Fecha { get; set; }

    }
}
