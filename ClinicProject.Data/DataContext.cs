using ClinicProject.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicProject.Data
{
    public class DataContext : DbContext
    {


        public DbSet<DoctorClass> Doctors { get; set; }
        public DbSet<PatientClass> Patients { get; set; }
        public DbSet<RoutesClass> routes { get; set; }


       



             protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Clinic");
            optionsBuilder.LogTo(m => Console.WriteLine(m));
        }



    }
}
