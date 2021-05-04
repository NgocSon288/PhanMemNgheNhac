using App.DatabaseLocal.Data;
using App.DatabaseLocal.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DatabaseLocal.Repository
{
    public abstract class RepositoryBase<T> : IRepository<T> where T : class
    {
        private FileHelper<T> fileHelper;

        protected RepositoryBase()
        {
            fileHelper = new FileHelper<T>();
        }

        public bool DeleteAll()
        {
            return fileHelper.DeleteAll();
        }

        public bool DeleteByID(Guid id)
        {
            return fileHelper.DeleteByID(id);
        }

        public List<T> GetAll()
        {
            return fileHelper.GetAll();
        }

        public T GetByID(Guid id)
        {
            return fileHelper.GetByID(id);
        }

        public bool Insert(T entity)
        {
            return fileHelper.Insert(entity);
        }

        public bool InsertRange(List<T> entities, bool isOveride = true)
        {
            return fileHelper.InsertRange(entities, isOveride);
        }

        public bool Update(T entity)
        {
            return fileHelper.Update(entity);
        }
    }
}
