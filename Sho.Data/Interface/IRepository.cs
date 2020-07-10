using System;
using System.Collections.Generic;
using System.Text;

namespace Sho.Data.Interface
{
    public interface IRepository<T>
    {
        T GetById(int id);
        List<T> GetAll();
        void Create(T entity);
        void Update(T enitity);        
        void Delete(int id);
    }
}
