using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDani.Model
{
  public class Usuario
    {
        public int IdUsuario { get; set; }
        public String login { get; set; }
        public String password { get; set; }

        public String nombre { get; set; }
        public String apellidos { get; set; }
        public String foto { get; set; }
    }
}
