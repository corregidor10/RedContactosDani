using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDani.Model
{
   public class Mensaje
    {
        public int idUsuario { get; set; }
        public int idOrigen { get; set; }
        public int idDestino { get; set; }

        public String asunto { get; set; }
        public String contenido { get; set; }
        public bool leido { get; set; }
        public DateTime fecha { get; set; }

    }
}
