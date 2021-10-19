using AppCarsUsers.Context;
using AppCarsUsers.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCarsUsers.Repositories {
    interface IRepository<TEntity> where TEntity : class  {

        List<TEntity> List();

        TEntity Get(int id);

        void Create(TEntity entity);

        void Edit(TEntity entity);

        void Delete(int id);
    }
}
