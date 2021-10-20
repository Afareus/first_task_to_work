using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Models {
    public class Car {

        [Key]
        public int Id { get; set; }

        public int UserId { get; set; }

        [Required]
        [StringLength(10)]
        public string SPZ { get; set; }

        public DateTime? Year_of_built { get; set; }   // tady by asi stačil int

        public virtual CarBrand CarBrand { get; set; }

        [StringLength(20)]
        public string CarBrandAlternate { get; set; }

        public byte? CountOfPlaces { get; set; }


        //public DateTime DeleteTime { get; set; }        // steně jako v User

    }


}