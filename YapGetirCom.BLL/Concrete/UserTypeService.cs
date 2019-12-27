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
            throw new NotImplementedException();
        }

        public void Delete(UserType entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(UserType entity)
        {
            throw new NotImplementedException();
        }

        public UserType Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<UserType> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
