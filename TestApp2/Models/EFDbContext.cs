using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace TestApp2.Models
{
        public class EFDbContext : DbContext
        {
        public DbSet<Contact> Contact { get; set; }
        public DbSet<User> User { get; set; }
        public DbSet<Roles> Roles { get; set; }
        
    }
}