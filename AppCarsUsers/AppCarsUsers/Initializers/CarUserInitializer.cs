using AppCarsUsers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;

namespace AppCarsUsers.Context {
    internal class CarUserInitializer : DropCreateDatabaseIfModelChanges<CarsUsersContext> {

        protected override void Seed(CarsUsersContext context) {
            base.Seed(context);

            var defaultUsers = new List<User>();

            defaultUsers.Add(new User() { FirstName = "Pepa", LastName = "Novák", DateOfBirth = new DateTime(1988, 11, 22) });
            defaultUsers.Add(new User() { FirstName = "Gabriel", LastName = "Kovács", DateOfBirth = new DateTime(1989, 4, 9), PersonIdNumber = "123456/5555", address = new Address { Street = "Závodní 2431", City = "Karviná", ZIP = "73504" } });
            defaultUsers.Add(new User() { FirstName = "Tom", LastName = "Hofer", DateOfBirth = new DateTime(1987, 12, 19), PersonIdNumber = "444456/5445", address = new Address { Street = "Haškova 158", City = "Karviná", ZIP = "73501" } });
            defaultUsers.Add(new User() { FirstName = "Markéta", LastName = "Kovácsová", DateOfBirth = new DateTime(1990,1, 11), PersonIdNumber = "121116/1115", address = new Address { Street = "Závodní 2431", City = "Karviná", ZIP = "11111" } });

            var CarsUser1 = new List<Car>();
            var CarsUser2 = new List<Car>();
            var CarsUser3 = new List<Car>();

            CarsUser1.Add(new Car() { CarBrand = CarBrand.Citroën, SPZ = "abc2545", Year_of_built = new DateTime(2010, 1, 1), CountOfPlaces = 5 });
            CarsUser1.Add(new Car() { CarBrand = CarBrand.Audi, SPZ = "aaa2545", Year_of_built = new DateTime(2011, 1, 1), CountOfPlaces = 5 });
            CarsUser1.Add(new Car() { CarBrand = CarBrand.Fiat, SPZ = "hhh2545", Year_of_built = new DateTime(2012, 1, 1), CountOfPlaces = 5 });
            CarsUser2.Add(new Car() { CarBrand = CarBrand.Citroën, SPZ = "kkk2545", Year_of_built = new DateTime(2013, 1, 1), CountOfPlaces = 4 });
            CarsUser2.Add(new Car() { CarBrand = CarBrand.Seat, SPZ = "nnnnn45", Year_of_built = new DateTime(2008, 1, 1), CountOfPlaces = 5 });
            CarsUser2.Add(new Car() { CarBrand = CarBrand.Škoda, SPZ = "a555545", Year_of_built = new DateTime(2008, 1, 1), CountOfPlaces = 5 });
            CarsUser2.Add(new Car() { CarBrand = CarBrand.Toyota, SPZ = "vvvv545", Year_of_built = new DateTime(2010, 1, 1), CountOfPlaces = 5 });
            CarsUser3.Add(new Car() { CarBrand = CarBrand.Kia, SPZ = "1111145", Year_of_built = new DateTime(2011, 1, 1), CountOfPlaces = 5 });

            defaultUsers[0].UserCars = CarsUser1;
            defaultUsers[1].UserCars = CarsUser2;
            defaultUsers[2].UserCars = CarsUser3;


            context.Users.AddRange(defaultUsers);
            context.Cars.AddRange(CarsUser1);
            context.Cars.AddRange(CarsUser2);
            context.Cars.AddRange(CarsUser3);

            context.SaveChanges();

        }

    }
}