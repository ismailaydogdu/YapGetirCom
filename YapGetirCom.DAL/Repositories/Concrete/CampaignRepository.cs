using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YapGetirCom.Core.DataAccess.EntityFramework;
using YapGetirCom.DAL.Repositories.Abstract;
using YapGetirCom.Model;

namespace YapGetirCom.DAL.Repositories.Concrete
{
    public class CampaignRepository : EFRepositoryBase<Campaign>, ICampaignRepository
    {
        public CampaignRepository(YapGetirComDbContext db) : base(db)
        {

        }
    }
}
