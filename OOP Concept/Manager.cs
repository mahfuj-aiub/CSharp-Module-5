using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagement
{
    class Manager:Employee
    {
        private int yearsOfExperience;
        public Manager(string id,string name,string add,int yoe) : base(id, name, add)
        {
            this.yearsOfExperience = yoe;
        }
        public override bool EmployeeStatus()
        {
            if (this.yearsOfExperience > 2)
            {
                return true;
            }
            else
                return false;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Id {0} Name : {1} Address : {2}",this.EmpId,this.EmpName,this.EmpAddress);
            if (this.EmployeeStatus())
            {
                Console.WriteLine("Eligible");
            }
            else
                Console.WriteLine(" Not Eligible ");
        }
    }
}
