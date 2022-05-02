using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICommentService<T> where T : class, IEntity, new()
    {
        List<T> GetList(int id); 
        void Add(T entity);
    }
}
