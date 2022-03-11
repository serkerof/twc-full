using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfOrderDal : EfEntityRepositoryBase<Order, TWCContext>, IOrderDal
    {
    }
}