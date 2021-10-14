using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Models {
    public class Car {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SPZ { get; set; }
        public DateTime Year_of_built { get; set; }   // tady by asi stačil int
        public int CarBrandId { get; set; }
        public string CarBrandAlternate { get; set; }
        public byte CountOfPlaces { get; set; }

        //public DateTime DeleteTime { get; set; }        // steně jako v User


    }
}