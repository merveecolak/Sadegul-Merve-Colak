using BussAppBussines.Abstract;
using BussAppData.Abstract;
using BussAppData.Concrete.EfCore;
using BussAppEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussAppBussines.Concrete
{
    public class ExpeditionManager : IExpeditionService
    {
        private IExpeditionRepository _expeditionRepository;

        public ExpeditionManager(IExpeditionRepository expeditionRepository)
        {
            _expeditionRepository = expeditionRepository;
        }

        public void Create(Expedition entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Expedition entity)
        {
            throw new NotImplementedException();
        }

        public List<Expedition> GetAll()
        {
            throw new NotImplementedException();
        }

        public Expedition GetById(Expedition Entity)
        {
            throw new NotImplementedException();
        }

        public Expedition GetExpenditionById(int id)
        {
            return _expeditionRepository.GetExpenditionById(id);
        }

        public List<Expedition> SelectedExpedition(string nereden, string nereye, string tarih)
        {
            return _expeditionRepository.SelectedExpedition(nereden, nereye, tarih);
        }

        public void Update(Expedition entity)
        {
            throw new NotImplementedException();
        }
    }
}
