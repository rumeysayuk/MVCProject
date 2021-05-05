using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
   public interface IContentService
    {
        IDataResult<List<Content>> GetAll();
        IDataResult<List<Content>> GetById(int contentId);
        IResult Add(Content content);
        IResult Update(Content content);
        IResult Delete(Content content);
    }
}
