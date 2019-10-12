using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalAppointmentSystem.Models
{
    public class HASRepostory
    {
        public List<Appointmment> GetAppointmments()
        {
            HASDatabase hasDatabase = new HASDatabase();
            return hasDatabase.Appointmment.ToList();
        }
    }
}