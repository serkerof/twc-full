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
    public class CommenterManager : ICommenterService
    {

        private ICommenterDal _commenterDal;


        public CommenterManager(ICommenterDal commenterDal)
        {
            _commenterDal = commenterDal;
        }

        public IResult Add(Commenter commenter)
        {
            _commenterDal.Add(commenter);
            return new SuccessResult(Messages.Success + commenter.Name);
        }
      

        public IResult Delete(Commenter commenter)
        {
            _commenterDal.Delete(commenter);
            return new SuccessResult(Messages.Deleted  + commenter.Name);
        }

        public IResult Update(Commenter commenter)
        {
            _commenterDal.Update(commenter);
            return new SuccessResult(Messages.Updated + commenter.Name);
        }

        public IDataResult<Commenter> Get(int id)
        {
            return new SuccessDataResult<Commenter>(_commenterDal.Get(filter: x => x.ID == id));

        }

        public IDataResult<List<Commenter>> GetList()
        {
            return new SuccessDataResult<List<Commenter>>(_commenterDal.GetList());
        }
    }
}

