using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayersRepository.DataAccessLayer
{
    public class Players
    {
        public int Id;
        public string Name;
        public string Address;
        public string Team;
        public int Salary;
        public DateTime JoinDate;
        public DateTime RetireDate;
        public string Time;
        public Players()
        {
        }
        public Players(int id, string name, string address, string team, int salary, DateTime joinDate, DateTime retireDate, string time)
        {
            Id = id;
            Name = name;
            Address = address;
            Team = team;
            Salary = salary;
            JoinDate = joinDate;
            RetireDate = retireDate;
            Time = time;
        }
        public string GetOccupationYear()
        {
            TimeSpan activeTime = RetireDate - JoinDate;
            int years = activeTime.Days / 365;
            int months = (activeTime.Days - years * 365) / 30;
            int days = (activeTime.Days - years * 365 - months * 30);
            return years.ToString() + " years " + months.ToString() + " months " + days.ToString() + " days.";
        }
    }
}
