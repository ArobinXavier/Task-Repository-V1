using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApi_Users_big_Task.Model;

namespace WebApi_Users_big_Task.DataBase
{
    public class AroInfoDbContext : DbContext
    {
        public AroInfoDbContext(DbContextOptions<AroInfoDbContext> options) : base(options)
        {

        }
        public DbSet<Language> Language { get; set; }
        public DbSet<Country> Country { get; set; }
        public DbSet<Company> Company { get; set; }
    }
}
