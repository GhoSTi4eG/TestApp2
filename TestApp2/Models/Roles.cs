using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TestApp2.Models
{
    public class Roles
    {
        [Key]
        public int id { get; set; }
        public Boolean Role { get; set; }
    }
}