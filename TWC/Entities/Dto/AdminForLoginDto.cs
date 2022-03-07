using Core.Entities.Abstract;
using Entities.Concrete;

namespace Entities.Dto
{
    public class AdminForLoginDto : IDto
    {
        public int EmailID { get; set; }
        public string? Password { get; set; }
        List<Email>? Emails { get; set; }
    }
}
