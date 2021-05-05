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
   public class WriterManager:IWriterService
   {
       private IWriterDal _writerDal;

       public WriterManager(IWriterDal writerDal)
       {
           _writerDal = writerDal;
       }
        public IDataResult<List<Writer>> GetAll()
        {
            return new ErrorDataResult<List<Writer>>(_writerDal.GetAll());
        }

        public IDataResult<List<Writer>> GetById(int writerId)
        {
            return new ErrorDataResult<List<Writer>>(_writerDal.GetAll(w=>w.Id==writerId));
        }

        public IResult Add(Writer writer)
        {
            _writerDal.Add(writer);
            return new SuccessResult(Messages.WriterAdded);
        }

        public IResult Update(Writer writer)
        {
            _writerDal.Update(writer);
            return new SuccessResult(Messages.WriterUpdated);
        }

        public IResult Delete(Writer writer)
        {
            _writerDal.Delete(writer);
            return new SuccessResult(Messages.WriterDeleted);
        }
    }
}
