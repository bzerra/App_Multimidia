using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Interface.repository
{
    public interface IBaseRepository<T> where T : class
    {
        IEnumerable<T> GetAll();
        T GetObj(int Key);
        T Insert(T obj);
        T Update(T obj);
        void Delete(T obj);
    }
}
