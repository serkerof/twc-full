using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract;

public interface ICustomerService
{
    IDataResult<List<Customer>> GetList();
    IDataResult<Customer> Get(int id);
    IResult Add(Customer customer);
    IResult Update(Customer customer);
    IResult Delete(Customer customer);

    List<OperationClaim> GetClaims(Customer customer);
    Customer GetByMail(string email);
}