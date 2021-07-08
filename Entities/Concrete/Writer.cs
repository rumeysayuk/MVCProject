using System.Collections.Generic;
using Core.Entities;

namespace Entities.Concrete
{
  public  class Writer:IEntity
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Image { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
