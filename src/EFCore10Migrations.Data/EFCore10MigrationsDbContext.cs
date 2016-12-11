using Microsoft.EntityFrameworkCore;
using EFCore10Migrations.Data.Models;

namespace EFCore10Migrations.Data
{
    public class EFCore10MigrationsDbContext : DbContext
    {
        public DbSet<Product> Projects { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=EFCore10Migrations;Trusted_Connection=True;");
        }
    }
}
