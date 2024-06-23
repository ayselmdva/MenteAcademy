using ConsoleApp.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.DAL
{
    internal class AppDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server= DESKTOP-0VMN37K\\SQLEXPRESS01; Database = MenteAcademy; Encrypt=False; Trusted_Connection=True");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<City> Cities { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Student> Students { get; set; }

    }
}
