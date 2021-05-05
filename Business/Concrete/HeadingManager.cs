using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
  public  class HeadingManager:IHeadingService
  {
      private IHeadingDal _headingDal;

      public HeadingManager(IHeadingDal headingDal)
      {
          _headingDal = headingDal;
      }
        public IDataResult<List<Heading>> GetAll()
        {
            return new SuccessDataResult<List<Heading>>(_headingDal.GetAll());
        }

        public IDataResult<List<Heading>> GetById(int headingId)
        {
            return new SuccessDataResult<List<Heading>>(_headingDal.GetAll(h=>h.Id==headingId));
        }

        public IResult Add(Heading heading)
        {
           _headingDal.Add(heading);
           return new SuccessResult(Messages.HeadingAdded);
        }

        public IResult Update(Heading heading)
        {
            _headingDal.Update(heading);
            return new SuccessResult(Messages.HeadingUpdated);
        }

        public IResult Delete(Heading heading)
        {
            _headingDal.Delete(heading);
            return new SuccessResult(Messages.HeadingDeleted);
        }
    }
}
