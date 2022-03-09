using Entities.Concrete;
using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class CommenterForRegisterDto : IDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public Email Email { get; set; }

    }
}