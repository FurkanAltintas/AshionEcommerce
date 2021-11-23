using BLL.Abstract;
using DAL.Abstract;
using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class UserManager : IUserService
    {
        IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public void Add(User p)
        {
            _userDal.Add(p);
        }

        public void Delete(User p)
        {
            _userDal.Delete(p);
        }

        public void Delete(int id)
        {
            _userDal.Delete(null, id);
        }

        public User Get(Expression<Func<User, bool>> filter = null)
        {
            return filter == null ?
                _userDal.Get() :
                _userDal.Get(filter);
        }

        public User Get(int id)
        {
            return _userDal.Get(id);
        }

        public List<User> List(Expression<Func<User, bool>> filter = null)
        {
            return filter == null ?
                _userDal.List() :
                _userDal.List(filter);
        }

        public bool Log(User p)
        {
            var log = _userDal.Get(x => x.Email == p.Email && x.Password == p.Password && x.IsActive);
            return log == null ? false : true;
        }

        public void Update(User p)
        {
            _userDal.Update(p);
        }
    }
}
