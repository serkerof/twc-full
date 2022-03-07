using Autofac;
using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFrameWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<UserManager>().As<IUserService>();
            builder.RegisterType<EfUserDal>().As<IUserDal>();

            builder.RegisterType<ServiceManager>().As<IServiceService>();
            builder.RegisterType<EfServiceDal>().As<IServiceDal>();

            builder.RegisterType<AdminManager>().As<IAdminService>();
            builder.RegisterType<EfAdminDal>().As<IAdminDal>();

            builder.RegisterType<EmployeeManager>().As<IEmployeeService>();
            builder.RegisterType<EfEmployeeDal>().As<IEmployeeDal>();

            builder.RegisterType<CustomerManager>().As<ICustomerService>();
            builder.RegisterType<EfCustomerDal>().As<ICustomerDal>();

            builder.RegisterType<OrderManager>().As<IOrderService>();
            builder.RegisterType<EfOrderDal>().As<IOrderDal>();

            builder.RegisterType<CommenterManager>().As<ICommenterService>();
            builder.RegisterType<EfCommenterDal>().As<ICommenterDal>();
        }
    }
}
