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

        private CarsUsersContext _dbContext;
        public CarRepository(CarsUsersContext db) {
            _dbContext = db;
        }

        public List<Car> List() {
            return _dbContext.Cars.ToList();
        }

        public Car Get(int id) {
            return _dbContext.Cars.Find(id);
        }

        public void Create(Car car) {
            _dbContext.Cars.Add(car);
            _dbContext.SaveChanges();
        }

        public void Edit(Car car) {
            _dbContext.Entry(car).State = EntityState.Modified;
            _dbContext.SaveChanges();
        }

        public void Delete(int id) {
            Car car = _dbContext.Cars.Find(id);
            _dbContext.Cars.Remove(car);
            _dbContext.SaveChanges();
        }

    }
}