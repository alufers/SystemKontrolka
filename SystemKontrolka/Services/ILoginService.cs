using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemKontrolka.Services
{
    /// <summary>
    /// LoginService facilitates checking user permissions and logging in.
    /// </summary>
    public interface ILoginService
    {
           public Task<bool> CheckUserCredentials(String user, String password);
        
    }
}
