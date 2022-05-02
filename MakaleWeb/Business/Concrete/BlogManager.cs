using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BlogManager : IBlogService<Blog>
    {
        private IBlogDal blogDal;
        public BlogManager(IBlogDal blogDal)
        {
            this.blogDal = blogDal;
        }


        public List<Blog> GetList()
        {
            return blogDal.GetList();
        }
        public Blog Get()
        {
            throw new NotImplementedException();
        }


        public void Add(Blog entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Blog entity)
        {
            throw new NotImplementedException();
        }
        public void Update(Blog entity)
        {
            throw new NotImplementedException();
        }

        public List<Blog> GetBlogWithCategory()
        {
            return blogDal.GetBlogWithCategory();
        }

        public List<Blog> GetBlogById(int id)
        {
            return blogDal.GetList(p => p.BlogId == id);
        }
    }
}
