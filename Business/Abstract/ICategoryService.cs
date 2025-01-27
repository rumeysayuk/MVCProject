﻿using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;


namespace Business.Abstract
{
    public interface ICategoryService
    {
       IDataResult<List<Category>>  GetAll();
       IDataResult<List<Category>> GetById(int categoryId);
       IResult Add(Category category);
       IResult Update(Category category);
       IResult Delete(Category category);

    }
}
