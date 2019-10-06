using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalAppointmentSystem.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string profession { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public int polyclinicId { get; set; }
        public int doctorId { get; set; }
        public bool isHappen { get; set; }
    }
}