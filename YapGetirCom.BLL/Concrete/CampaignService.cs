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
    public class CampaignService : ICampaignService
    {
        public ICampaignRepository _campaignRepository;

        public CampaignService(ICampaignRepository campaignRepository)
        {
            _campaignRepository = campaignRepository;
        }
        public void Insert(Campaign entity)
        {
            _campaignRepository.Add(entity);
        }

        public void Delete(Campaign entity)
        {
            _campaignRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _campaignRepository.Delete(Get(id));
        }

        public void Update(Campaign entity)
        {
            _campaignRepository.Update(entity);
        }

        public Campaign Get(int entityID)
        {
            return _campaignRepository.Get(x => x.CampaignID == entityID);
        }

        public ICollection<Campaign> GetAll()
        {
            return _campaignRepository.GetAll();
        }
    }
}
