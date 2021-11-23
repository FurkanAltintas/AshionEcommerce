using BLL.Abstract;
using DAL.Abstract;
using ENTITY.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Concrete
{
    public class AuthorizationManager : IAuthorizationService
    {
        IEmployeeDal _employeeDal;
        IUserDal _userDal;

        public AuthorizationManager(IEmployeeDal employeeDal, IUserDal userDal)
        {
            _employeeDal = employeeDal;
            _userDal = userDal;
        }

        public bool EmployeeLog(Employee p)
        {
            var auth = _employeeDal.Get(x => x.Email == p.Email && x.Password == p.Password);
            return auth == null ? false : true;
        }

        public bool UserLog(User p)
        {
            var auth = _userDal.Get(x => x.Email == p.Email && x.Password == p.Password);
            return auth == null ? false : true;
        }
    }
}
