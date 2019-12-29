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
    public class MessageService : IMessageService
    {
        public IMessageRepository _messageRepository;
        public MessageService(IMessageRepository messageRepository)
        {
            _messageRepository = messageRepository;
        }
        public void Insert(Message entity)
        {
            _messageRepository.Add(entity);
        }

        public void Delete(Message entity)
        {
            _messageRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _messageRepository.Delete(Get(id));
        }

        public void Update(Message entity)
        {
            _messageRepository.Update(entity);
        }

        public Message Get(int entityID)
        {
            return _messageRepository.Get(x => x.MessageID == entityID);
        }

        public ICollection<Message> GetAll()
        {
            return _messageRepository.GetAll();
        }
    }
}
