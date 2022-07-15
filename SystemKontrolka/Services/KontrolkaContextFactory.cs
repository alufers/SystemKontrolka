using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SystemKontrolka.Services
{
    public class KontrolkaContextFactory : IDesignTimeDbContextFactory<KontrolkaDbContext>
    {
        public KontrolkaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<KontrolkaDbContext>();
            optionsBuilder.UseSqlite("Data Source=Kontrolka.db");

            return new KontrolkaDbContext(optionsBuilder.Options);
        }
    }
}
