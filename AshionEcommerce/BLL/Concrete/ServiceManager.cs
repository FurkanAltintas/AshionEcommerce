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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public void Add(Service p)
        {
            _serviceDal.Add(p);
        }

        public void Delete(Service p)
        {
            _serviceDal.Delete(p);
        }

        public void Delete(int id)
        {
            _serviceDal.Delete(null, id);
        }

        public Service Get(Expression<Func<Service, bool>> filter = null)
        {
            return filter == null ?
                 _serviceDal.Get() :
                 _serviceDal.Get(filter);
        }

        public Service Get(int id)
        {
            return _serviceDal.Get(id);
        }

        public List<Service> List(Expression<Func<Service, bool>> filter = null)
        {
            return filter == null ?
                _serviceDal.List() :
                _serviceDal.List(filter);
        }

        public void Update(Service p)
        {
            _serviceDal.Update(p);
        }
    }
}
