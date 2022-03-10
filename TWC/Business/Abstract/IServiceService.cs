﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
namespace Business.Abstract
{
    public interface IServiceService
    {
        IDataResult<List<Service>> GetList();
        IDataResult<Service> Get(int id);
        IResult Add(Service service);
        IResult Update(Service service);
        IResult Delete(Service service);
    }
}
