using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CommentManager : ICommentService<Comment>
    {
        private ICommentDal commentDal;
        public CommentManager(ICommentDal commentDal)
        {
            this.commentDal = commentDal;
        }
        public void Add(Comment entity)
        {
            throw new NotImplementedException();
        }

        public List<Comment> GetList(int id)
        {
            return commentDal.GetList(p => p.BlogId == id);
        }
    }
}
