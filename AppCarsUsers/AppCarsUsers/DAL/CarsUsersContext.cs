using AppCarsUsers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppCarsUsers.DAL {
    public class CarsUsersContext : DbContext  {

        public CarsUsersContext() : base("CarsUsersContext") {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Address> Adresses { get; set; }
       

    }
}