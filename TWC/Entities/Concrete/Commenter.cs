using Core.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Entities.Concrete
{
    public class Commenter : IEntities
    {

        public int ID { get; set; }
        public string? Name { get; set; }
        public string? Surname { get; set; }
        public int EmailID { get; set; }
        public string? Message { get; set; }
        public int UserID { get; set; }
        public int AdminID { get; set; }

    }
}