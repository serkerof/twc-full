using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities.Concrete
{
    public class Admin : IEntities
    {

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int EmailID { get; set; }
        public string? MobileNumber { get; set; }
        public string? Password { get; set; }

    }
}

