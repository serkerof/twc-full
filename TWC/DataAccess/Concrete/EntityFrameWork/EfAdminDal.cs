using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Microsoft.EntityFrameworkCore;
using Core.DataAccess.Concrete;

namespace DataAccess.Concrete.EntityFrameWork
{
    public class EfAdminDal : EfEntityRepositoryBase<Admin, TWCContext>, IAdminDal
    {
      
        
      
    }
}