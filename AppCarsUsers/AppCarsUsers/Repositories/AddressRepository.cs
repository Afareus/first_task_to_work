using AppCarsUsers.Context;
using AppCarsUsers.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AppCarsUsers.Repositories {
    public class AddressRepository : IRepository<Address> {

        private CarsUsersContext _db;
        public AddressRepository(CarsUsersContext db) {
            _db = db;
        }

        public List<Address> List() {
            return _db.Adresses.ToList();
        }

        public Address Get(int id) {
            return _db.Adresses.Find(id);
        }

        public void Create(Address address) {
            _db.Adresses.Add(address);
            _db.SaveChanges();
        }

        public void Edit(Address address) {
            _db.Entry(address).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id) {
            Address address = _db.Adresses.Find(id);
            _db.Adresses.Remove(address);
            _db.SaveChanges();
        }
    }
}