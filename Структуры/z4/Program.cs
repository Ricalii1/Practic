using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace z4
{
    enum Employees
    {
        Junior_Developer = 100,
        Middle_Devaloper = 150,
        Senior_Developer = 200,
        Database_Administrator = 250,
        Project_Manager = 300
    }

    class Accauntant
    {
        public bool AskForBonus(Employees PostEmp, int hours)
        {
            if ((int)PostEmp < hours)
                return true;
            else
                return false;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Accauntant acc = new Accauntant();
            Console.WriteLine(acc.AskForBonus(Employees.Junior_Developer, 100));
            Console.WriteLine(acc.AskForBonus(Employees.Middle_Devaloper, 210));
            Console.WriteLine(acc.AskForBonus(Employees.Senior_Developer, 225));
            Console.WriteLine(acc.AskForBonus(Employees.Database_Administrator, 220));
            Console.WriteLine(acc.AskForBonus(Employees.Project_Manager, 340));
            Console.ReadKey();
        }
    }
}
