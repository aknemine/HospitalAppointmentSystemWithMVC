using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace HospitalAppointmentSystem.Models
{
    public class HASDatabase : DbContext
    {
        public HASDatabase():base("HASDatabase")
        {

        }
        
        public DbSet<Appointmment> Appointmment { get; set; }
        public DbSet<City> City { get; set; }
        public DbSet<Town> Town { get; set; }
        public DbSet<Hospital> Hospital { get; set; }
        public DbSet<Doctor> Doctor { get; set; }
        public DbSet<Patient> Patient { get; set; }
        public DbSet<Polyclinic> Polylinic { get; set; }

        
    }

    
}