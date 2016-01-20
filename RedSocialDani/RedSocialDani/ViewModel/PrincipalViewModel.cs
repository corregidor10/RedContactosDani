using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RedSocialDani.Factorias;
using RedSocialDani.Service;

namespace RedSocialDani.ViewModel
{
    public class PrincipalViewModel:GeneralViewModel
    {
        public PrincipalViewModel(INavigator navigator, IServicioDatos servicio) : base(navigator, servicio)
        {
        }
    }
}
