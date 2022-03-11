using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract;

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