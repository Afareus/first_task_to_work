using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Models {
    public class Address {
        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [StringLength(50)]
        public string City { get; set; }
        
        [StringLength(60)]
        public string Street { get; set; }

        [StringLength(10)]
        public string ZIP { get; set; }

    }
}