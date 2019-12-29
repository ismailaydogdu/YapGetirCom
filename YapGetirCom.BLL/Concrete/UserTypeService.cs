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
    public class UserTypeService : IUserTypeService
    {
        public IUserTypeRepository _userTypeRepository;
        public UserTypeService(IUserTypeRepository userTypeRepository)
        {
            _userTypeRepository = userTypeRepository;
        }
        public void Insert(UserType entity)
        {
            _userTypeRepository.Add(entity);
        }

        public void Delete(UserType entity)
        {
            _userTypeRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _userTypeRepository.Delete(Get(id));
        }

        public void Update(UserType entity)
        {
            _userTypeRepository.Update(entity);
        }

        public UserType Get(int entityID)
        {
            return _userTypeRepository.Get(x => x.UserTypeID == entityID);
        }

        public ICollection<UserType> GetAll()
        {
            return _userTypeRepository.GetAll();
        }
    }
}
