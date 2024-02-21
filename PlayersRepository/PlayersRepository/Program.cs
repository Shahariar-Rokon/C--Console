using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PlayersRepository.BusinessLayer;
using PlayersRepository.DataAccessLayer;

namespace PlayersRepository
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PlayerBusiness PlayerBusiness = new PlayerBusiness(new PlayerRepository());
            bool isRunning = true;
            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type\n 1 for List\n 2 for search\n 3 for Add\n 4 for Update\n 5 for Delete\n 6 for Clear\n 7 for Exit\n");
                    int command = int.Parse(Console.ReadLine());
                    if (command == 1)
                    {
                        List<Players> _listPlayer = PlayerBusiness.Get();
                        Console.WriteLine("List of Players:");
                        Console.WriteLine("ID |   Name  |   Address | Team | Salary | Join Date | Retire Date | Time in the team");
                        foreach (Players _p in _listPlayer)
                        {
                            Console.WriteLine("ID:" + _p.Id + "\tName:" + _p.Name + "\tAddress:" + _p.Address + "\tTeam:" + _p.Team + "\tSalary:" + _p.Salary + "\tJoinDate:" + _p.JoinDate.ToShortDateString() + "\tRetireDate:" + _p.RetireDate.ToShortDateString() + "\tTime in the team:" + _p.Time);
                        }
                    }
                    else if (command == 2)
                    {
                        Console.WriteLine("Input a id to find a Player:");
                        string id = Console.ReadLine();
                        Players _p = PlayerBusiness.Get(Convert.ToInt32(id));
                        Console.WriteLine(_p.Id + "  |   " + _p.Name + "  |   " + _p.Address + "  |   " + _p.Team + "  |   " + _p.Salary + "  |   " + _p.JoinDate.ToShortDateString() + "  |   " + _p.RetireDate.ToShortDateString() + "  |   " + _p.Time);
                    }
                    else if (command == 3)
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Console.WriteLine("Input Team Name:");
                        string team = Console.ReadLine();
                        Console.WriteLine("Input salary:");
                        int salary = int.Parse(Console.ReadLine());
                        Console.Write("Date of Join (mm/dd/yyyy): ");
                        DateTime joinDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Date of Retire (mm/dd/yyyy): ");
                        DateTime retireDate = Convert.ToDateTime(Console.ReadLine());

                        Players _p = new Players();
                        _p.Id = Convert.ToInt32(id);
                        _p.Name = name;
                        _p.Address = address;
                        _p.Team = team;
                        _p.Salary = salary;
                        _p.JoinDate = joinDate;
                        _p.RetireDate = retireDate;
                        _p.Time = _p.GetOccupationYear();

                        bool isExecuted = PlayerBusiness.Add(_p);
                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == 4)
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a name:");
                        string name = Console.ReadLine();
                        Console.WriteLine("Input a address:");
                        string address = Console.ReadLine();
                        Console.WriteLine("Input Team Name:");
                        string team = Console.ReadLine();
                        Console.WriteLine("Input a salary:");
                        int salary = int.Parse(Console.ReadLine());
                        Console.Write("Date of Join (mm/dd/yyyy): ");
                        DateTime joinDate = Convert.ToDateTime(Console.ReadLine());
                        Console.Write("Date of Retire (mm/dd/yyyy): ");
                        DateTime retireDate = Convert.ToDateTime(Console.ReadLine());
                        Players _p = new Players();
                        _p.Id = Convert.ToInt32(id);
                        _p.Name = name;
                        _p.Address = address;
                        _p.Team = team;
                        _p.Salary = salary;
                        _p.JoinDate = joinDate;
                        _p.RetireDate = retireDate;
                        _p.Time = _p.GetOccupationYear();
                        bool isExecuted = PlayerBusiness.Update(_p);
                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == 5)
                    {
                        Console.WriteLine("Input a id:");
                        string id = Console.ReadLine();
                        bool isExecuted = PlayerBusiness.Delete(Convert.ToInt32(id));
                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == 6)
                    {
                        Console.Clear();
                    }
                    else if (command == 7)
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
       
        }
    }
}
