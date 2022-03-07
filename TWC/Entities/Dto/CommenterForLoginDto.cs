using Entities.Concrete;

namespace Entities.Dto
{
    public class CommenterForLoginDto
    {
        public int EmailID { get; set; }
        public string? Password { get; set; }
        public List<Email>? Emails { get; set; }
    }
}
