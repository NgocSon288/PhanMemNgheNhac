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
    public interface ISongSeenService
    {
        bool InsertRange(List<SongSeen> entities, bool isOveride = true);

        bool Insert(SongSeen entity);

        List<SongSeen> GetAll();

        SongSeen GetByID(Guid id);

        List<SongSeen> GetByTopCount(int count);

        bool DeleteAll();

        bool DeleteByID(Guid id);

        bool Update(SongSeen entity);
    }

    public class SongSeenService : ISongSeenService
    {
        private readonly ISongSeenRepository _filmRepository;

        public SongSeenService()
        {
            this._filmRepository = new SongSeenRepository();
        }

        public bool DeleteAll()
        {
            return _filmRepository.DeleteAll();
        }

        public bool DeleteByID(Guid id)
        {
            return _filmRepository.DeleteByID(id);
        }

        public List<SongSeen> GetAll()
        {
            return _filmRepository.GetAll().ToList();
        }

        public SongSeen GetByID(Guid id)
        {
            return _filmRepository.GetByID(id);
        }

        public List<SongSeen> GetByTopCount(int count)
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

        public bool Insert(SongSeen entity)
        {
            return _filmRepository.Insert(entity);
        }

        public bool InsertRange(List<SongSeen> entities, bool isOveride = true)
        {
            return _filmRepository.InsertRange(entities, isOveride);
        }

        public bool Update(SongSeen entity)
        {
            return _filmRepository.Update(entity);
        }
    }
}
