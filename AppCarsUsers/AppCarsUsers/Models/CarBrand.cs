using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Models {
    public enum CarBrand {
        [Description("žádný z uvedených")]
        Other,
        [Description("Audi")]
        Audi,
        [Description("BMW")]
        BMW,
        [Description("Citroën")]
        Citroën,
        [Description("Dacia")]
        Dacia,
        [Description("Fiat")]
        Fiat,
        [Description("Ford")]
        Ford,
        [Description("Honda")]
        Honda,
        [Description("Hyundai")]
        Hyundai,
        [Description("Kia")]
        Kia,
        [Description("Mazda")]
        Mazda,
        [Description("Mercedes")]
        Mercedes,
        [Description("Opel")]
        Opel,
        [Description("Peugeot")]
        Peugeot,
        [Description("Renault")]
        Renault,
        [Description("Seat")]
        Seat,
        [Description("Škoda")]
        Škoda,
        [Description("Subaru")]
        Subaru,
        [Description("Suzuki")]
        Suzuki,
        [Description("Toyota")]
        Toyota,
        [Description("Volkswagen")]
        Volkswagen,


    }
}