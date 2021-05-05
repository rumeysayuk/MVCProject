using System;
using System.Collections.Generic;
using System.Text;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using Entities.Concrete;
using DataAccess.Abstract;

namespace Business.Concrete
{
   public class AboutManager:IAboutService

   {
       private IAboutDal _aboutDal;

       public AboutManager(IAboutDal aboutDal)
       {
           _aboutDal = aboutDal;
       }
        public IDataResult<List<About>> GetAll()
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetAll());
        }

        public IDataResult<List<About>> GetById(int aboutId)
        {
            return new SuccessDataResult<List<About>>(_aboutDal.GetAll(a => a.Id == aboutId));
        }

        public IResult Add(About about)
        {
            _aboutDal.Add(about);
            return new SuccessResult(Messages.AboutAdded);
        }

        public IResult Update(About about)
        {
            _aboutDal.Update(about);
            return new SuccessResult(Messages.AboutUpdated);
        }

        public IResult Delete(About about)
        {
            _aboutDal.Delete(about);
            return new SuccessResult(Messages.AboutDeleted);
        }
    }
}
