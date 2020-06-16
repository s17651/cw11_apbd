using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace APBD_c11.Models
{
    public class cw11DbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }

        public DbSet<Patient> Patients { get; set; }

        public DbSet<Prescriptions> Prescriptions { get; set; }

        public DbSet<Medicaments> Medicaments { get; set; }

        public DbSet<Prescription_Medicament> Prescription_Medicaments { get; set; }

        public cw11DbContext() { }

        public cw11DbContext(DbContextOptions context) 
        :base(context){ 
            
        }
        
        protected override void OnModelCreating(ModelBuilder builder) 
        {
            var doctors = new List<Doctor>();
            doctors.Add(new Doctor { IdDoctor = 1, FirstName = "Jan", LastName = "Kowalski", Email = "jan@kowalski.pl" });
            doctors.Add(new Doctor { IdDoctor = 2, FirstName = "Tomek", LastName = "Zając", Email = "tomek@zajac.pl" });
            builder.Entity<Doctor>()
                    .HasData(doctors);

            builder.Entity<Prescription_Medicament>()
                    .HasKey(k => new { k.IdPrescription, k.IdMedicament });
        }
        
        
    }
}
