using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICategoryService<T> where T : class,IEntity, new()
    {
        List<T> GetList();
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
