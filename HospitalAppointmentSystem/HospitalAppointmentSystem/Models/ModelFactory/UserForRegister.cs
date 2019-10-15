using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalAppointmentSystem.Models.ModelFactory
{
    public class UserForRegister
    {
        public int Id { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public string gender { get; set; }
        public string bloodGroup { get; set; }
        public string telephone { get; set; }
        public string email { get; set; }
        public int age { get; set; }
        public string password { get; set; }
    }
}