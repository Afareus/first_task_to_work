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
    public class UserRepository : IRepository<User> {

        private CarsUsersContext _db;
        public UserRepository(CarsUsersContext db) {        // constructor - Dependecy injection
            _db = db;
        }


        public List<User> List() {
            return _db.Users.ToList();       
        }

        public User Get(int id) {
            return _db.Users.Find(id);
        }

        public void Create(User user) {
            _db.Users.Add(user);
            _db.SaveChanges();
        }

        public void Edit(User user) {
            _db.Entry(user).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(int id) {
            User user = _db.Users.Find(id);
            _db.Users.Remove(user);
            _db.SaveChanges();
        }
    }
}