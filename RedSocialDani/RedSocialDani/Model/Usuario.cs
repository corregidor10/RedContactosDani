﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RedSocialDani.Model
{
  public class Usuario
    {
        public String IdUsuario { get; set; }
        public String Login { get; set; }
        public String Password { get; set; }

        public String Nombre { get; set; }
        public String Apellidos { get; set; }
        public String Foto { get; set; }
    }
}
