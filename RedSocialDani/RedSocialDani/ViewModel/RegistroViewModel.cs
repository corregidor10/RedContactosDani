using System.Windows.Input;
using RedSocialDani.Factorias;
using RedSocialDani.Model;
using RedSocialDani.Service;
using Xamarin.Forms;

namespace RedSocialDani.ViewModel
{
    public class RegistroViewModel:GeneralViewModel
    {
        public ICommand cmdAlta { get; set; }

        public Usuario Usuario
        {
            get { return _usuario; }
            set { SetProperty(ref _usuario, value); }
        }

        private Usuario _usuario = new Usuario();

        public RegistroViewModel(INavigator navigator, IServicioDatos servicio) : base(navigator, servicio)
        {
            cmdAlta = new Command(GuardarUsuario);
        }

        private async void GuardarUsuario()
        {
            try
            {
                IsBusy = true;
                var r = await _servicio.AddUsuario(_usuario);
                if (r != null)
                {
                    await _navigator.PushModalAsync<PrincipalViewModel>();
                }
                else
                {
                    var a = "";
                }
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}