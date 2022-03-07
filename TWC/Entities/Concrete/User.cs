using Core.Entities.Abstract;

namespace Entities.Concrete
{
    public class User : IEntities
    {
        public int ID { get; set; }
        public int Name { get; set; }
        public int Surname { get; set; }
        public int EmailID { get; set; }
        public int MobileNumber { get; set; }
        public int Password { get; set; }

    }
}