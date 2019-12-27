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
            throw new NotImplementedException();
        }

        public void Delete(Scoring entity)
        {
            throw new NotImplementedException();
        }

        public void DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(Scoring entity)
        {
            throw new NotImplementedException();
        }

        public Scoring Get(int entityID)
        {
            throw new NotImplementedException();
        }

        public ICollection<Scoring> GetAll()
        {
            throw new NotImplementedException();
        }
    }
}
