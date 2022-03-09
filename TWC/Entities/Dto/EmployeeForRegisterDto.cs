using Entities.Concrete;
using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class EmployeeForRegisterDto : IDto
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string MobileNumber { get; set; }
        public Email Email { get; set; }
    }
}
