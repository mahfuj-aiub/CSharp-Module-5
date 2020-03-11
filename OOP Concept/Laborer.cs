using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagement
{
    class Laborer:Employee
    {
        private int noOfSerivce, userRating, earn = 0;
        private const int chragePerService = 500;
        public Laborer(string id,string name,string add,int ur,int nos) : base(id, name, add)
        {
            this.userRating = ur;
            this.noOfSerivce = nos;
        }
        public override bool EmployeeStatus()
        {
            if (this.userRating > 70 && this.noOfSerivce >= 10)
            {
                return true;
            }
            else
                return false;
        }
        public int TotalEarn()
        {
            this.earn = this.noOfSerivce * chragePerService;
            return this.earn;
        }
        public override void ShowInfo()
        {
            Console.WriteLine("Id {0} Name : {1} Address : {2}", this.EmpId, this.EmpName, this.EmpAddress);
            if (this.EmployeeStatus())
            {
                Console.WriteLine("Eligible");
            }
            else
                Console.WriteLine(" Not Eligible ");
            Console.WriteLine("{0} total earning is : {1}",this.EmpName, this.TotalEarn());
        }
        public bool UserRating
        {
            get
            {
                if (this.userRating > 80)
                {
                    return true;
                }
                else
                    return false;
            }

        }
    }
}
