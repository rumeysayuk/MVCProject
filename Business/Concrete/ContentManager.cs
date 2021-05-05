using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using FluentValidation.Internal;

namespace Business.Concrete
{
   public class ContentManager:IContentService
   {
       private IContentDal _contentDal;

       public ContentManager(IContentDal contentDal)
       {
           _contentDal = contentDal;
       }

       public IDataResult<List<Content>> GetAll()
       {
           return new ErrorDataResult<List<Content>>(_contentDal.GetAll());
       }

       public IDataResult<List<Content>> GetById(int contentId)
       {
           return new ErrorDataResult<List<Content>>(_contentDal.GetAll(c=>c.Id==contentId));
        }

       public IResult Add(Content content)
       {
          _contentDal.Add(content);
          return new SuccessResult(Messages.ContentAdded);
       }

       public IResult Update(Content content)
       {
           _contentDal.Update(content);
           return new SuccessResult(Messages.ContentUpdated);
        }

       public IResult Delete(Content content)
       {
           _contentDal.Delete(content);
           return new SuccessResult(Messages.ContentDeleted);
        }
   }
}
