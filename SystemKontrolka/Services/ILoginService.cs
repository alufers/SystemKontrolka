using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemKontrolka.Models;

namespace SystemKontrolka.Services
{
    /// <summary>
    /// LoginService facilitates checking user permissions and logging in.
    /// </summary>
    public interface ILoginService
    {
        /// <summary>
        /// Checks whether a user with the given credentials exits
        /// </summary>
        /// <param name="user"></param>
        /// <param name="password">plaintext password</param>
        /// <returns>the found user</returns>
        public Task<User> CheckUserCredentials(String user, String password);

        /// <summary>
        /// Checks whether there are any users in the system,
        /// if there are none it creates a default admin account.
        /// </summary>
        /// <returns>if created the account</returns>
        public Task<bool> CreateAdminUserIfNone();

    }
}
