using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Entities.Concrete
{
    public class Email:IEntities
    {
        public int ID { get; set; }
        public string? EmailAddress { get; set; }
        public string? Password { get; set; }
    }
}
