using System.Collections.Generic;
using Entities.Concrete;

namespace DataAccess.Abstract
{
   public interface IHeadingDal
   {
       List<Heading> GetList();

       void Add(Heading heading);
   }
}
