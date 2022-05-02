
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
    public class CategoryManager : ICategoryService<Category>
    {
        private ICategoryDal categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            this.categoryDal = categoryDal;
        }

        public List<Category> GetList()
        {
            return categoryDal.GetList();
        }
        public Category Get()
        {
            throw new NotImplementedException();
        }








        public void Add(Category entity)
        {
            categoryDal.Add(entity);
        }

        public void Delete(Category entity)
        {
            throw new NotImplementedException();
        }
        public void Update(Category entity)
        {
            throw new NotImplementedException();
        }

    }
}
