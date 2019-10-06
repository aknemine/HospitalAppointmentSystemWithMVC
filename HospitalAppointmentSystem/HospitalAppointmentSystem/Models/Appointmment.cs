using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalAppointmentSystem.Models
{
    public class Appointmment
    {
        public int Id { get; set; }
        public DateTime date { get; set; }
        public int patientId { get; set; }
        public int doctorId { get; set; }
        public bool isHappen { get; set; }

    }
}