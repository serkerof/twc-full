using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract
{
    public interface IEmployeeService
    {
        IDataResult<List<Employee>> GetList();

        IDataResult<Employee> Get(int id);

        IResult Add(Employee employee);

        IResult Update(Employee employee);

        IResult Delete(Employee employee);

        List<OperationClaim> GetClaims(Employee employee);

        Employee GetByMail(string email);
    }
}