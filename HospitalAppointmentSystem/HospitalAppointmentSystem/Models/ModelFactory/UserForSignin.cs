using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalAppointmentSystem.Models.ModelFactory
{
    public class UserForSignin
    {
        public int Id { get; set; }
        public string password { get; set; }
        public string SigninErrorMsg { get; set; }
    }
}