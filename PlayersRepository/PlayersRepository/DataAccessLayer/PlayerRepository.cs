using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersRepository.DataAccessLayer
{
    public class PlayerRepository : IPlayerRepository
    {
        List<Players> listPlayer = new List<Players>()
        {
            new Players(1, "Luka","USA","Arsenal",55000,Convert.ToDateTime("1/1/1997"),Convert.ToDateTime("1/1/2005"),"8year 5 month 12 days"),
            new Players(2, "Pedro", "Armania", "ManU", 50000, Convert.ToDateTime("1/1/1997"), Convert.ToDateTime("1/1/2005"), "8year 5 month 12 days"),
            new Players(3, "Aman", "Germany", "RealMadrid", 65000, Convert.ToDateTime("1/1/1997"), Convert.ToDateTime("1/1/2005"), "8year 5 month 12 days"),
            new Players(4, "Xavi", "Russia", "Barca", 45000, Convert.ToDateTime("1/1/1997"), Convert.ToDateTime("1/1/2005"), "8year 5 month 12 days")
        };
        public List<Players> Get()
        {
            return listPlayer.OrderBy(x => x.Name).ToList();
        }

        public Players Get(int id)
        {
            Players Player = listPlayer.Where(x => x.Id == id).FirstOrDefault();
            return Player;
        }

        public bool Add(Players model)
        {
            listPlayer.Add(model);
            return true;
        }

        public bool Update(Players model)
        {
            bool isExecuted = false;
            Players Player = listPlayer.Where(x => x.Id == model.Id).FirstOrDefault();
            if (Player != null)
            {
                listPlayer.Remove(Player);
                listPlayer.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool Delete(int id)
        {
            bool isExecuted = false;
            Players oPlayer = listPlayer.Where(x => x.Id == id).FirstOrDefault();
            if (oPlayer != null)
            {
                listPlayer.Remove(oPlayer);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
