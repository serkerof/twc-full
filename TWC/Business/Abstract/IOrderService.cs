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