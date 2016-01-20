using Autofac;
using RedSocialDani.Factorias;
using Xamarin.Forms;

namespace RedSocialDani.Modulo
{
    public class AutofacModule:Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ViewFactory>().
                As<IViewFactory>().
                SingleInstance();

            builder.RegisterType<Navigator>().
                As<INavigator>().SingleInstance();

            builder.Register<INavigation>(
                ctx => App.Current.MainPage.Navigation).SingleInstance();


        }

    }
}