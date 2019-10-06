using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalAppointmentSystem.Models
{
    public class Polyclinic
    {
        public int Id { get; set; }
        public string name { get; set; }
        public int hospitalId { get; set; }
    }
}