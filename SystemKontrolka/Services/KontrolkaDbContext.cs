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
    /// This is the main Db context for the kontrolka system.
    /// It facilitates connecting to the database and querying it.
    /// </summary>
    public class KontrolkaDbContext:DbContext
    {

        /// <summary>
        /// This is the dbset of users.
        /// </summary>
        public DbSet<User> Users { get; set; }

        /// <summary>
        /// This is the dbset of login history entries
        /// </summary>
        public DbSet<LoginHistoryEntry> loginHistoryEntries { get; set; }

        /// <summary>
        /// This is the dbset of parts
        /// </summary>
        public DbSet<Part> Parts { get; set; }

        public KontrolkaDbContext(DbContextOptions<KontrolkaDbContext> options) : base(options)
        {
         

        }

    }
}
