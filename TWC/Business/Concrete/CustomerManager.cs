﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Concrete
{
    public class CustomerManager : ICustomerService
    {

        private ICustomerDal _customerDal;

        public CustomerManager(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public IResult Add(Customer customer)
        {
            return new SuccessResult(Messages.Success + customer.Name);
        }

        public IResult Delete(Customer customer)
        {
            return new SuccessResult(Messages.Deleted + customer.Name);
        }

        public IResult Update(Customer customer)
        {
            return new SuccessResult(Messages.Updated + customer.Name);
        }

        public IDataResult<Customer> Get(int id)
        {
            return new SuccessDataResult<Customer>(_customerDal.Get(filter: x => x.ID == id));

        }

        public IDataResult<List<Customer>> GetList()
        {
            return new SuccessDataResult<List<Customer>>(_customerDal.GetList());
        }

        public List<OperationClaim> GetClaims(Customer customer)
        {
            throw new NotImplementedException();
        }

        public Customer GetByMail(string email)
        {
            throw new NotImplementedException();
        }
    }
}
