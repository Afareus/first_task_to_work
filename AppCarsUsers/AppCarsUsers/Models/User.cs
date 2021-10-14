using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Models {
    public class User {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int AddressId { get; set; }
        public string PersonIdNumber { get; set; }
        public DateTime DateOfBirth { get; set; }       // tady si nejsem jistý jestli nechat DateTime když čas nebudu potřebovat

        public List<User> UserCar { get; set; }

        //public DateTime DeleteTime  { get; set; }       // nějaké datum bude jako defaultní a když bude jiné, tak záznam bude označený jako smazaný (bude se nastavovat při deleteUser)

    }
}