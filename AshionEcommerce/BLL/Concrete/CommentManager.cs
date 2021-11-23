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
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commentDal)
        {
            _commentDal = commentDal;
        }

        public void Add(Comment p)
        {
            _commentDal.Add(p);
        }

        public void Delete(Comment p)
        {
            _commentDal.Delete(p);
        }

        public void Delete(int id)
        {
            _commentDal.Delete(null, id);
        }

        public Comment Get(Expression<Func<Comment, bool>> filter = null)
        {
            return filter == null ?
                _commentDal.Get() :
                _commentDal.Get(filter);
        }

        public Comment Get(int id)
        {
            return _commentDal.Get(id);
        }

        public List<Comment> List(Expression<Func<Comment, bool>> filter = null)
        {
            return filter == null ?
                _commentDal.List() :
                _commentDal.List(filter);
        }

        public void Update(Comment p)
        {
            _commentDal.Update(p);
        }
    }
}
