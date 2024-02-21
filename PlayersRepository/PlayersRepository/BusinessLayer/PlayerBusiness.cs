using PlayersRepository.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersRepository.BusinessLayer
{
    public class PlayerBusiness
    {
        IPlayerRepository _repository;

        public PlayerBusiness(IPlayerRepository repository)
        {
            _repository = repository;
        }

        public List<Players> Get()
        {
            return _repository.Get();
        }

        public Players Get(int id)
        {
            return _repository.Get(id);
        }

        public bool Add(Players model)
        {
            return _repository.Add(model);
        }

        public bool Update(Players model)
        {
            return _repository.Update(model);
        }

        public bool Delete(int id)
        {
            return _repository.Delete(id);
        }
    }
}
