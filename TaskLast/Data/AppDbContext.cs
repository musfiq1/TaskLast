using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaskLast.Models;

namespace TaskLast.Data
{
    public class AppDbContext : IdentityDbContext<CustomUser>
    {
        public AppDbContext(DbContextOptions options):base(options)
        {

        }

        public DbSet<FirstTable> FirstTables { get; set; }
        public DbSet<SecondTable> SecondTables { get; set; }
        public DbSet<CustomUser> CustomUsers { get; set; }
    }
}
