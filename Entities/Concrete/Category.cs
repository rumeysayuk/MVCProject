using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using Core.Entities;

namespace Entities.Concrete
{
   public class Category:IEntity
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
      
        public string Description { get; set; }
        public bool Status { get; set; }

    }
}
