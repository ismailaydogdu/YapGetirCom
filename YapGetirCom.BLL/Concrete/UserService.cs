using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.BLL.Abstract;
using YapGetirCom.DAL.Repositories.Abstract;
using YapGetirCom.DTO;
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
            try
            {
                entity.CreateDate = DateTime.Now;
                entity.IsActive = true;
                _userRepository.Add(entity);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

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

        public User Login(LoginDTO loginDto)
        {

            User user = _userRepository.Get(x => x.EMail == loginDto.Email);

            if (user != null)
            {
                if (user.Password == loginDto.Password)
                {
                    return user;
                }
                else
                {
                    return null;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
