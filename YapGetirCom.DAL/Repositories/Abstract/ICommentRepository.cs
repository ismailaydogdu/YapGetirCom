using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.DataAccess;
using YapGetirCom.Model;
using YapGetirCom.Core.DataAccess.EntityFramework.Abstract;

namespace YapGetirCom.DAL.Repositories.Abstract
{
    public interface ICommentRepository : IEFBaseRepository<Comment>
    {

    }
}
