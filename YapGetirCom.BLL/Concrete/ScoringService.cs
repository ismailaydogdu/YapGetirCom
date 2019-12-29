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
    public class ScoringService : IScoringService
    {
        public IScoringRepository _scoringRepository;
        public ScoringService(IScoringRepository scoringRepository)
        {
            _scoringRepository = scoringRepository;
        }
        public void Insert(Scoring entity)
        {
            _scoringRepository.Add(entity);
        }

        public void Delete(Scoring entity)
        {
            _scoringRepository.Delete(entity);
        }

        public void DeleteById(int id)
        {
            _scoringRepository.Delete(Get(id));
        }

        public void Update(Scoring entity)
        {
            _scoringRepository.Update(entity);
        }

        public Scoring Get(int entityID)
        {
            return _scoringRepository.Get(x => x.ScoringID == entityID);
        }

        public ICollection<Scoring> GetAll()
        {
            return _scoringRepository.GetAll();
        }
    }
}
