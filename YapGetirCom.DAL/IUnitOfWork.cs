
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.DAL.Repositories.Abstract;

namespace YapGetirCom.DAL
{
    public interface IUnitOfWork
    {
        ICampaignRepository CampaignRepository { get; }

        int Complete();
    }
}
