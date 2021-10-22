using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Models {
    public class User {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]        // autoinkrementace při přidání řádku do databáze
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        //public int? AddressId { get; set; }

        [StringLength(16)]
        public string PersonIdNumber { get; set; }

        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DateOfBirth { get; set; }      

        public virtual ICollection<Car> UserCars { get; set; }

        //[ForeignKey("Id")]
        public virtual Address address { get; set; }

        [NotMapped]
        public int CountCars { get { return UserCars?.Count() ?? 0; } }        // pokud je UserCars.Count() null, tak vrátí 0


        //public DateTime DeleteTime  { get; set; }       // nějaké datum bude jako defaultní a když bude jiné, tak záznam bude označený jako smazaný (bude se nastavovat při deleteUser)
    }
}