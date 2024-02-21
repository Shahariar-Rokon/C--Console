using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersRepository.DataAccessLayer
{
    public interface IPlayerRepository
    {
        List<Players> Get();
        Players Get(int id);
        bool Add(Players model);
        bool Update(Players model);
        bool Delete(int id);
    }
}
