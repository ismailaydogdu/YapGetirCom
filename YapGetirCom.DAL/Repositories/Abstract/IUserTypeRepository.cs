using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.DataAccess;
using YapGetirCom.Core.DataAccess.EntityFramework.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Repositories.Abstract
{
    public interface IUserTypeRepository : IEFBaseRepository<UserType>
    {
    }
}
