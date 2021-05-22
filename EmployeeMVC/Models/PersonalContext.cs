using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeMVC.Models
{
    public class PersonalContext:DbContext
    {
        public PersonalContext()
        {

        }
        public PersonalContext(DbContextOptions options):base(options)
        {

        }
        public DbSet<Personal> Personals { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Personal>().HasData(new Personal() { Id = 1, Name = "Navreen",
                Qualification = "Engineer", IsEmployed = "Yes", NoticePeriod = "21 May,2019", CurrentCTC = 350000 });
        }
    }
}
