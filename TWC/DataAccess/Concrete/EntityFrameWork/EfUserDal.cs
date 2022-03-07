using System.Linq.Expressions;
using Core.DataAccess.Concrete;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfUserDal : EfEntityRepositoryBase<User, TWCContext>, IUserDal
    {
       

        
    }
}
