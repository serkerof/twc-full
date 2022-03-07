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
    public class AdminManager : IAdminService
    {

        private IAdminDal _adminDal;


        public AdminManager(IAdminDal adminDal)
        {
            _adminDal = adminDal;
        }

        public IResult Add(Admin admin)
        {
            _adminDal.Add(admin);
            return new SuccessResult(Messages.Success + admin.Name);
        }

        public IResult Delete(Admin admin)
        {
            _adminDal.Delete(admin);
            return new SuccessResult(Messages.Deleted + admin.Name);
        }

        public IResult Update(Admin admin)
        {
            _adminDal.Update(admin);
            return new SuccessResult(Messages.Updated + admin.Name);
        }

        public IDataResult<Admin> Get(int id)
        {
            return new SuccessDataResult<Admin>(_adminDal.Get(filter: x => x.ID == id)) ;

        }

        public IDataResult<List<Admin>> GetList()
        {
            return new SuccessDataResult<List<Admin>>(_adminDal.GetList());
        }

       
    }
}
