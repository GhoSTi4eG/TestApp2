using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestApp2.Models
{
    public class User
    {
        [Key]
        public int TabN { get; set; }
        public string FIO { get; set; }
        public string InNmb { get; set; }
        public string OtNmb { get; set; }
        public string Adres { get; set; }
        public string Email { get; set; }
        public DateTime Date { get; set; }
        public Boolean Role  { get; set; }
        public Boolean Registred { get; set; }
    }
}