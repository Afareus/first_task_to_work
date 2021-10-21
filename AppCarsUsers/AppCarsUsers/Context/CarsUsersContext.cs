using AppCarsUsers.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Context {
    public class CarsUsersContext : DbContext  {

        public CarsUsersContext() : base("CarsUsersConnection") {
            
            this.Configuration.LazyLoadingEnabled = false;                        // vypnutí lazyloadingu
            this.Database.Log = s => System.Diagnostics.Debug.WriteLine(s);       // výpis logu do outputu
            Database.SetInitializer(new CarUserInitializer());  

        }



        public DbSet<User> Users { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Address> Adresses { get; set; }
       

    }
}