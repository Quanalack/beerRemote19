using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerProduction.DAL.IRepo
{
    public interface IBaseRepository<T> where T : class
    {
        T Find(object id);
        void Add(T obj);
        void Update(T obj);
        void Remove(object id);
    }
}
