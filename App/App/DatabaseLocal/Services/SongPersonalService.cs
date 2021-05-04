using App.DatabaseLocal.Models;
using App.DatabaseLocal.Repository;
using App.DatabaseLocal.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.DatabaseLocal.Services
{ 
    public interface ISongPersonalService
    {
        bool InsertRange(List<SongPersonal> entities, bool isOveride = true);

        bool Insert(SongPersonal entity);

        List<SongPersonal> GetAll();

        SongPersonal GetByID(Guid id);

        List<SongPersonal> GetByTopCount(int count);

        bool DeleteAll();

        bool DeleteByID(Guid id);

        bool Update(SongPersonal entity);
    }

    public class SongPersonalService : ISongPersonalService
    {
        private readonly ISongPersonalRepository _filmRepository;

        public SongPersonalService()
        {
            this._filmRepository = new SongPersonalRepository();
        }

        public bool DeleteAll()
        {
            return _filmRepository.DeleteAll();
        }

        public bool DeleteByID(Guid id)
        {
            return _filmRepository.DeleteByID(id);
        }

        public List<SongPersonal> GetAll()
        {
            return _filmRepository.GetAll().ToList();
        }

        public SongPersonal GetByID(Guid id)
        {
            return _filmRepository.GetByID(id);
        }

        public List<SongPersonal> GetByTopCount(int count)
        {
            try
            { 
                return _filmRepository.GetAll().Take(count).ToList();
            }
            catch (Exception)
            {
                return _filmRepository.GetAll();
            }
        }

        public bool Insert(SongPersonal entity)
        {
            return _filmRepository.Insert(entity);
        }

        public bool InsertRange(List<SongPersonal> entities, bool isOveride = true)
        {
            return _filmRepository.InsertRange(entities, isOveride);
        }

        public bool Update(SongPersonal entity)
        {
            return _filmRepository.Update(entity);
        }
    }
}
