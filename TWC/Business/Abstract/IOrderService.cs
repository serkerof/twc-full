using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IOrderService
    {
        IDataResult<List<Order>> GetList();
        IDataResult<Order> Get(int id);
        IResult Add(Order order);
        IResult Update(Order order);
        IResult Delete(Order order);
    }
}
