using Entities.Concrete;

namespace Entities.Dto {
    public class AdminForLoginDto {
        public int EmailID { get; set; }
        public string? Password { get; set; }
        List<Email>? Emails { get; set; }
    }
}
