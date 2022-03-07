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

namespace Business.Concrete
{
    public class EmployeeManager : IEmployeeService
    {

        private IEmployeeDal _employeeDal;


        public EmployeeManager(IEmployeeDal employeeDal)
        {
            _employeeDal = employeeDal;
        }

        public IResult Add(Employee employee)
        {
            _employeeDal.Add(employee);
            return new SuccessResult(Messages.Success + employee.Name);
        }

        public IResult Delete(Employee employee)
        {
            _employeeDal.Delete(employee);
            return new SuccessResult(Messages.Deleted + employee.Name);
        }

        public IResult Update(Employee employee)
        {
            _employeeDal.Update(employee);
            return new SuccessResult(Messages.Updated + employee.Name);
        }

        public IDataResult<Employee> Get(int id)
        {
            return new SuccessDataResult<Employee>(_employeeDal.Get(filter: x => x.ID == id));

        }

        public IDataResult<List<Employee>> GetList()
        {
            return new SuccessDataResult<List<Employee>>(_employeeDal.GetList());
        }
    }
}
