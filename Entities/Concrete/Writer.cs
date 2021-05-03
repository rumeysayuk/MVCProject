using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
  public  class Writer:IEntity
    {
        public int Id { get; set; }
        public string WriterName { get; set; }
        public string WriterSurname { get; set; }
        public string WriterImage { get; set; }
        public string WriterMail { get; set; }
        public string WriterPassword { get; set; }
        //Yazar-başlık ilişkisi 

    }
}
