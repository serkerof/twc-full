using Entities.Concrete;

namespace Entities.Dto
{
    public class CommenterForRegisterDto
    {
        public int EmailID { get; set; }
        public string? Password { get; set; }
        public List<Email>? Emails { get; set; }
    }
}
