using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.Abstract
{
    public interface IAdminService
    {
        IDataResult<List<Admin>> GetList();
        IDataResult<Admin> Get(int id);
        IResult Add(Admin admin);
        IResult Update(Admin admin);
        IResult Delete(Admin admin);

        List<OperationClaim> GetClaims(Admin admin);
        Admin GetByMail(string email);
    }
}
