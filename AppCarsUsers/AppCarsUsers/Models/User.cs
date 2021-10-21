using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Models {
    public class User {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        public int? AddressId { get; set; }

        [StringLength(16)]
        public string PersonIdNumber { get; set; }

        public DateTime? DateOfBirth { get; set; }       // tady si nejsem jistý jestli nechat DateTime když čas nebudu potřebovat
    
        public virtual ICollection<Car> UserCars { get; set; }

        public virtual Address address { get; set; }

        //public DateTime DeleteTime  { get; set; }       // nějaké datum bude jako defaultní a když bude jiné, tak záznam bude označený jako smazaný (bude se nastavovat při deleteUser)

    }
}