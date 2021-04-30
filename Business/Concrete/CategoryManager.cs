using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;


namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        private ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }
        public List<Category> GetAll()
        {
            return new List<Category>(_categoryDal.GetAll());
        }

        public List<Category> GetById(int categoryId)
        {
            return new List<Category>(_categoryDal.GetAll(c => c.Id == categoryId));
        }
    }
}
