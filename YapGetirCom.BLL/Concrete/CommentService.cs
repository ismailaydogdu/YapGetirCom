using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.DAL.Repositories.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.BLL.Concrete
{
    public class CommentService : ICommentService
    {
        public ICommentRepository _commentRepository;
        public CommentService(ICommentRepository commentRepository)
        {
            _commentRepository = commentRepository;
        }
        public void Insert(Comment entity)
        {
            _commentRepository.Add(entity);
        }

        public void Delete(Comment entity)
        {
            _commentRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _commentRepository.Delete(Get(id));
        }

        public void Update(Comment entity)
        {
            _commentRepository.Update(entity);
        }

        public Comment Get(int entityID)
        {
            return _commentRepository.Get(x => x.CommentID == entityID);
        }

        public ICollection<Comment> GetAll()
        {
            return _commentRepository.GetAll();
        }
    }
}
