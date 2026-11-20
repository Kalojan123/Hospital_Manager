using Data_Hospital_Manager.Configurations;
using Data_Hospital_Manager.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Runtime.Intrinsics.Arm;
using System.Text;
using System.Threading.Tasks;

namespace Data_Hospital_Manager
{
    public class HospitalDbContext:DbContext
    {
        public HospitalDbContext(DbContextOptions<HospitalDbContext> options)
            : base(options)
        {
        }

        public DbSet <Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<DoctorPatient> DoctorPatients { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);            
            modelBuilder.ApplyConfiguration(new HospitalConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorConfiguration());
            modelBuilder.ApplyConfiguration(new PatientConfiguration());
            modelBuilder.ApplyConfiguration(new DoctorPatientConfiguration());
        }
    }
}
