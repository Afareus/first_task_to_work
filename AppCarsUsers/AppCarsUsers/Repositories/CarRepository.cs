using AppCarsUsers.Context;
using AppCarsUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Net;
using System.Web.Mvc;

namespace AppCarsUsers.Repositories {
    public class CarRepository : IRepository<Car> {

        private CarsUsersContext _db;
        public CarRepository(CarsUsersContext db) {
            _db = db;
        }

        public List<Car> List() {
            return _db.Cars.ToList();
        }

        public Car Get(int id) {
            return _db.Cars.Find(id);
        }

        public void Create(Car car) {
            _db.Cars.Add(car);
            _db.SaveChanges();
        }

        public void Edit(Car car) {
            _db.Entry(car).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id) {
            Car car = _db.Cars.Find(id);
            _db.Cars.Remove(car);
            _db.SaveChanges();
        }

    }
}