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
    public class UserService : IUserService
    {
        public IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void Insert(User entity)
        {
            _userRepository.Add(entity);
        }

        public void Delete(User entity)
        {
            _userRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _userRepository.Delete(Get(id));
        }

        public void Update(User entity)
        {
            _userRepository.Update(entity);
        }

        public User Get(int entityID)
        {
            return _userRepository.Get(x => x.UserID == entityID);
        }

        public ICollection<User> GetAll()
        {
            return _userRepository.GetAll();
        }
    }
}
