using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using DataAccessLayer.EntityFramework.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
   public class EfCategoryDal:EfEntityRepositoryBase<Category,Context>,ICategoryDal
    {

    }
}
