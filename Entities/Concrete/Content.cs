﻿using System;
using Core.Entities;

namespace Entities.Concrete
{
   public class Content:IEntity
    {
        public int Id { get; set; }
        public string ContentValue { get; set; }
        public DateTime ContentDate { get; set; }

        public int HeadingId { get; set; }
        
        public int WriterId { get; set; }

    }
}
