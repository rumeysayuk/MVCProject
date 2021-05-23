﻿using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
   public class Category:IEntity
    {
       
        public int Id { get; set; }
        public string CategoryName { get; set; }
      
        public string CategoryDescription { get; set; }
        public bool CategoryStatus { get; set; }
        //public string CategoryHeading { get; set; }

        //İlişkiyi oluşturdum.
      
    }
}
