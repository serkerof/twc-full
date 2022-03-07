using Entities.Concrete;
using Core.Entities.Abstract;

namespace Entities.Dto
{
    public class CustomerForLoginDto : IDto
    {
        public int EmailID { get; set; }
        public string? Password { get; set; }
        public List<Email>? Emails { get; set; }
    }
}
