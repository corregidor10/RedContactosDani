using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.WindowsAzure.MobileServices;
using RedSocialDani.Model;
using RedSocialDani.Utils;

namespace RedSocialDani.Service
{
   public class ServicioDatosImpl:IServicioDatos
   {
       private MobileServiceClient client;

       public ServicioDatosImpl()
       {
           client=new MobileServiceClient(Cadenas.UrlServicio, Cadenas.TokenServicio);
       }




       public async Task<Usuario> ValidarUsuario(Usuario us)
       {
            var tabla = client.GetTable<Usuario>();
            try
            {
                var data = await tabla.CreateQuery().
                    Where(o => o.login == us.login && o.password == us.password).
                    ToListAsync();

                if (data.Count == 0)
                    return null;

                return data[0];
            }
            catch (Exception e)
            {
                return null;
            }
        }

       public async Task<Usuario> AddUsuario(Usuario us)
       {
            var tabla = client.GetTable<Usuario>();

            try
            {
                var data = await tabla.CreateQuery().Where(o => o.login == us.login)
                    .ToListAsync();
                if (data.Count > 0)
                    return null;
            }
            catch (Exception)
            {
                throw new Exception("Usuario ya registrado");
            }

            try
            {
                await tabla.InsertAsync(us);
            }
            catch (Exception)
            {
                throw new Exception("Error en la creacion del usuario");
            }
            return us;
        }

       public Task<Usuario> UpdateUsuario(Usuario us, string id)
       {
           throw new NotImplementedException();
       }

       public Task DeleteUsuario(string id)
       {
           throw new NotImplementedException();
       }
    }
}
