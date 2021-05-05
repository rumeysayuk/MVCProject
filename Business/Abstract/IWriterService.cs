using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
  public  interface IWriterService
    {
        IDataResult<List<Writer>> GetAll();
        IDataResult<List<Writer>> GetById(int writerId);
        IResult Add(Writer writer);
        IResult Update(Writer writer);
        IResult Delete(Writer writer);
    }
}
