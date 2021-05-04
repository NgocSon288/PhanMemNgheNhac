using System;
using System.Collections.Generic;

namespace App.DatabaseLocal.Repository.Interface
{
    public interface IRepository<T> where T : class
    {
        bool InsertRange(List<T> entities, bool isOveride = true);

        bool Insert(T entity);

        List<T> GetAll();

        T GetByID(Guid id);

        bool DeleteAll();

        bool DeleteByID(Guid id);

        bool Update(T entity);
    }
}