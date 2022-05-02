using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Generics;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class BlogDal : EntityRepositoryBase<Blog, MakaleContext>, IBlogDal
    {
        public List<Blog> GetBlogWithCategory()
        {
            using (var context = new MakaleContext())
            {
                return context.Blogs.Include(p => p.Category).ToList();
            }
        }
    }
}
