using System;
using System.Threading.Tasks;
using RedSocialDani.Model;

namespace RedSocialDani.Service
{
    public interface IServicioDatos
    {
        Task<Usuario> ValidarUsuario(Usuario us);
        Task<Usuario> AddUsuario(Usuario us);
        Task<Usuario> UpdateUsuario(Usuario us, String id);
        Task DeleteUsuario(String id);

    }
}