using Core.Entities;

namespace Entities.Concrete
{
   public class Contact:IEntity
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string UserMail { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
    }
}
