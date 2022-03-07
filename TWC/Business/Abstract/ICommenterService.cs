using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;
using NuGet.Protocol.Plugins;

namespace Business.Abstract
{
    public interface ICommenterService
    {
        IDataResult<List<Commenter>> GetList();
        IDataResult<Commenter> Get(int id);
        IResult Add(Commenter commenter);
        IResult Update(Commenter commenter);
        IResult Delete(Commenter commenter);

        List<OperationClaim> GetClaims(Commenter commenter);
        Commenter GetByMail(string email);

    }

}
