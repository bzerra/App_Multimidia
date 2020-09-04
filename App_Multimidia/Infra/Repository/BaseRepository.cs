using Domain.Interface.repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infra.Repository
{
    public class BaseRepository<T, DB> : IBaseRepository<T> where T : class where DB : DbContext
    {
        readonly protected DB _context;
        public BaseRepository(DB context)
        {
            _context = context;
        }

        public void Delete(T obj)
        {
            try
            {
                _context.Set<T>().Remove(obj);
                _context.SaveChanges();                

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public IEnumerable<T> GetAll()
        {
            try
            {
                return _context.Set<T>();                
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T GetObj(int Key)
        {
            try
            {
                return _context.Set<T>().Find(Key);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T Insert(T obj)
        {
            try
            {
                obj = _context.Set<T>().Add(obj).Entity;
                _context.SaveChanges();
                return obj;

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public T Update(T obj)
        {
            try
            {
                obj = _context.Set<T>().Update(obj).Entity;
                _context.SaveChanges();
                return obj;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
