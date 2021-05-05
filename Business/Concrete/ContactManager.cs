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
   public class ContactManager :IContactService
   {
       private IContactDal _contactDal;

       public ContactManager(IContactDal contactDal)
       {
           _contactDal = contactDal;
       }
        public IDataResult<List<Contact>> GetAll()
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll());
        }

        public IDataResult<List<Contact>> GetById(int contactId)
        {
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll(a => a.Id == contactId));
        }

        public IResult Add(Contact contact)
        {
            _contactDal.Add(contact);
            return new SuccessResult(Messages.ContactAdded);
        }

        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult(Messages.ContactUpdated);
        }

        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult(Messages.ContactDeleted);
        }
    }
}
