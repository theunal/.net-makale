using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IBlogService<T> where T : class, IEntity, new()
    {
        List<T> GetList();
        T Get();
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);

        // bunları degiştircem
        List<Blog> GetBlogWithCategory();
        List<Blog> GetBlogById(int id);

    }
}
