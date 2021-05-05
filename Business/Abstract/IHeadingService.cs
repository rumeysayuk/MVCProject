using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IHeadingService
    {
        IDataResult<List<Heading>> GetAll();
        IDataResult<List<Heading>> GetById(int headingId);
        IResult Add(Heading heading);
        IResult Update(Heading heading);
        IResult Delete(Heading heading);
    }
}
