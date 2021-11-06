using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class CommentManager : ICommentService
    {
        ICommentDal _commentDal;

        public CommentManager(ICommentDal commmentDal)
        {
            _commentDal = commmentDal;
        }

        public void CommentAdd(Comment comment)
        {
            _commentDal.Add(comment);
        }

        public void CommentDelete(Comment comment)
        {
            _commentDal.Delete(comment);
        }

        public void CommentUpdate(Comment comment)
        {
            _commentDal.Update(comment);
        }

        public List<Comment> GetList(int id)
        {

            return _commentDal.List(x => x.BlogID == id);//gönderilen id'ye göre Blog Id değeri 
                                                         //bu parametre id'ye eşit olan blogun yorumlarını getirir.

        }

       
    }
}
