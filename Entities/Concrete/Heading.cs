using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
   public class Heading:IEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime gDate { get; set; }
                                                                                                                            
        public int CategoryId { get; set; }
        public int WriterId { get; set; }


    }
}
