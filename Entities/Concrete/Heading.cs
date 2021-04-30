using System;
using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
   public class Heading:IEntity
    {

        public int Id { get; set; }
        public string HeadingName { get; set; }
        public DateTime HeadingDate { get; set; }

        //İlişkinin neyle kurulduğunu söyledim.
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        //Yazar-başlık ilşkisi
        public int WriterId { get; set; }
        public virtual Writer Writer{ get; set; }
        //İlişki kuracağı yeri söyledim.
        public ICollection<Content> Contents { get; set; }

    }
}
