using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, TWCContext>, IAdminDal
    {
    }
}