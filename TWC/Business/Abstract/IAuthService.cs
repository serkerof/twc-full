using Azure.Core;
using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Dto;

namespace Business.Abstract
{
    public interface IAuthService
    {
        IDataResult<User> Register(UserForRegisterDto userForRegisterDto, string password);

        IDataResult<User> Login(UserForLoginDto userForLoginDto);

        IResult UserExists(string email);

        IDataResult<AccessToken> CreateAccessToken(User user);

        IDataResult<Admin> Register(AdminForRegisterDto AdminForRegisterDto, string password);

        IDataResult<Admin> Login(AdminForLoginDto AdminForLoginDto);

        IResult AdminExists(string email);

        IDataResult<AccessToken> CreateAccessToken(Admin admin);

        IDataResult<Commenter> Login(CommenterForRegisterDto CommenterForRegisterDto, string password);

        IDataResult<Commenter> Login(CommenterForLoginDto CommenterForLoginDto);

        IResult CommenterExists(string email);

        IDataResult<AccessToken> CreateAccessToken(Commenter commenter);

        IDataResult<Customer> Register(CustomerForRegisterDto CustomerForRegisterDto, string password);

        IDataResult<Customer> Login(CustomerForLoginDto CustomerForLoginDto);

        IResult CustomerExists(string email);

        IDataResult<AccessToken> CreateAccessToken(Customer customer);

        IDataResult<Employee> Register(EmployeeForRegisterDto EmployeeForRegisterDto, string password);

        IDataResult<Employee> Login(EmployeeForLoginDto EmployeeForLoginDto);

        IResult EmployeeExists(string email);

        IDataResult<AccessToken> CreateAccessToken(Employee employee);
    }
}