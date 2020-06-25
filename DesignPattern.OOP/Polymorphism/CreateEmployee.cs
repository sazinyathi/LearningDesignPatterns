using DesignPattern.OOP.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.OOP.Polymorphism
{
    public class CreateEmployee
    {
        private List<Employees> employeelist = new List<Employees>();
        public void CreateEmployeeTypes(Employees employees)
        {
            employeelist.Add(new PartTimeEmployee());
            employeelist.Add(new FullTimeEmployee());
        }
    }
}
