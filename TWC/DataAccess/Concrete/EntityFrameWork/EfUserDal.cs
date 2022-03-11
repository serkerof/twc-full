using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfUserDal : EfEntityRepositoryBase<User, TWCContext>, IUserDal
    {
    }
}