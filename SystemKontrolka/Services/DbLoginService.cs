using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemKontrolka.Services
{
    internal class DbLoginService:ILoginService
    {
        public async Task<bool> CheckUserCredentials(string user, string password)
        {
            return user == "admin" && password == "admin";
        }
    }
}
