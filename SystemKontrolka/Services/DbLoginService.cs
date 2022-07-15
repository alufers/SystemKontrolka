using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SystemKontrolka.Models;

namespace SystemKontrolka.Services
{
    
    /// <summary>
    /// Database backed login service
    /// </summary>
    internal class DbLoginService : ILoginService
    {
        private readonly KontrolkaDbContext _kontrolkaDbContext;
        public DbLoginService(KontrolkaDbContext kontrolkaDbContext)
        {
            _kontrolkaDbContext = kontrolkaDbContext;
        }
        public async Task<User> CheckUserCredentials(string user, string password)
        {
            return await _kontrolkaDbContext.Users.FirstOrDefaultAsync(u => u.Username == user && u.Password == password);
        }

        public async Task<bool> CreateAdminUserIfNone()
        {
            if (_kontrolkaDbContext.Users.Count() == 0)
            {
                var adminUser = new User
                {
                    Username = "admin",
                    Password = "admin",
                    CanEditDefectTypes = true,
                    CanEditParts = true,
                    CanEditReports = true,
                    CanEditUsers = true,
                };
                _kontrolkaDbContext.Users.Add(adminUser);
                await _kontrolkaDbContext.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task CreateLoginHistoryEntry(User user, String action)
        {
            var loginHistory = new LoginHistoryEntry
            {
                User = user,
                Date = DateTime.Now,
                Action = action
            };
            _kontrolkaDbContext.loginHistoryEntries.Add(loginHistory);
            await _kontrolkaDbContext.SaveChangesAsync();
        }
    }
}
