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

        private CarsUsersContext _dbContext;
        public UserRepository(CarsUsersContext db) {        // constructor - Dependecy injection
            _dbContext = db;
        }


        public List<User> List() {

            // ___________________________ list uživatelů i s adresami pomocí LAZYLOADINGU _______________________________________

            //return _db.Users.ToList();             // pužívat jenom na zkoušku !

            // __________________________________ list uživatelů i s adresami pomocí JOIN ________________________________________

            //var usersData = from u in _db.Users
            //                join a in _db.Adresses on u.Id equals a.UserId into u2
            //                from a in u2.DefaultIfEmpty()
            //                select new { user = u, address = a };

            //return usersData.Select(data => data.user).ToList();

            // ______________________ list uživatelů s adresami i počtem aut pomocí metody INCLUDE _______________________________

            List<User> users = _dbContext.Users.Include(user => user.UserCars).Include(user => user.address).ToList();
            return users;

        }

        public User Get(int id) {

            return _dbContext.Users.Include(user => user.address).FirstOrDefault(user => user.Id == id);
        }

        public void Create(User user) {
            _dbContext.Users.Add(user);
            _dbContext.SaveChanges();
        }


        public void Edit(User user) {

            User us = _dbContext.Users.Include(u => u.address).FirstOrDefault(u => u.Id == user.Id);
            us.address = user.address;

            _dbContext.Entry(us).State = EntityState.Modified;
            

            _dbContext.SaveChanges();
        }

        public void Delete(int id) {
            User user = _dbContext.Users.Find(id);

            _dbContext.Users.Remove(user);
            _dbContext.SaveChanges();
        }
    }
}