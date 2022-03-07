using Entities.Concrete;
using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class EmployeeForLoginDto : IDto
    {
        public int EmailID { get; set; }
        public string? Password { get; set; }
        public List<Email>? Emails { get; set; }
    }
}
