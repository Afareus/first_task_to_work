using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Models {
    public class Address {
        
        public int Id { get; set; }
        public string City { get; set; }
        public string Street { get; set; }
        public string ZIP { get; set; }

    }
}