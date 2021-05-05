using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IAboutService
    {
        IDataResult<List<About>> GetAll();
        IDataResult<List<About>> GetById(int aboutId);
        IResult Add(About about);
        IResult Update(About about);
        IResult Delete(About about);
    }
}
