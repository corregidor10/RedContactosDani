using RedSocialDani.Factorias;
using RedSocialDani.Service;
using RedSocialDani.ViewModel.Base;

namespace RedSocialDani.ViewModel
{
    public class GeneralViewModel:ViewModelBase
    {
        protected INavigator _navigator;
        protected IServicioDatos _servicio;

        public GeneralViewModel(INavigator navigator, IServicioDatos servicio)
        {
            _navigator = navigator;
            _servicio = servicio;
        }
    }
}