using landing.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace landing.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Person> Persons { get; set; }
    }
}
