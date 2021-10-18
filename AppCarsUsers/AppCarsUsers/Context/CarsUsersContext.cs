using AppCarsUsers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Context {
    public class CarsUsersContext : DbContext  {

        public CarsUsersContext() : base("CarsUsersConnection") {
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Address> Adresses { get; set; }
       

    }
}