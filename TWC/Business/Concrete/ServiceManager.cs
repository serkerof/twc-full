using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ServiceManager:IServiceService
    {
        private IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public IResult Add(Service service)
        {
            _serviceDal.Add(service);
            return new SuccessResult(Messages.Success + service.Name);
        }

        public IResult Delete(Service service)
        {
            _serviceDal.Delete(service);
            return new SuccessResult(Messages.Deleted + service.Name);
        }

        public IResult Update(Service service)
        {
            _serviceDal.Update(service);
            return new SuccessResult(Messages.Updated + service.Name);
        }

        public IDataResult<Service> Get(int id)
        {
            return new SuccessDataResult<Service>(_serviceDal.Get(filter: x => x.ID == id));

        }

        public IDataResult<List<Service>> GetList()
        {
            return new SuccessDataResult<List<Service>>(_serviceDal.GetList());
        }
    }
}
