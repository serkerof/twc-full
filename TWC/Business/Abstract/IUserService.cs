using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract
{
    public interface IUserService
    {
        IDataResult<List<User>> GetList();

        IDataResult<User> Get(int id);

        IResult Add(User user);

        IResult Update(User user);

        IResult Delete(User user);

        List<OperationClaim> GetClaims(User user);

        User GetByMail(string email);
    }
}