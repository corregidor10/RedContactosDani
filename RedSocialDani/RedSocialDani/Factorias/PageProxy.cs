using System;
using Xamarin.Forms;

namespace RedSocialDani.Factorias
{
    public class PageProxy:IPage
    {
        readonly Func<Page> _page;

        public PageProxy(Func<Page> page)
        {
            _page = page;
        }
        public INavigation Navigation { get { return _page().Navigation; } }
    }
}