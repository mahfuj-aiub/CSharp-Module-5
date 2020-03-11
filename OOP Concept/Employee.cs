using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagement
{
    class Employee
    {
		private string empName;
		private string  empId;
		private string  empAddress;
		public Employee(string id,string name,string add)
		{
			this.empId = id;
			this.empName = name;
			this.empAddress = add;
		}
		public string  EmpAddress
		{
			get { return empAddress; }
			set { empAddress = value; }
		}


		public string  EmpId
		{
			get { return empId; }
			set { empId = value; }
		}


		public string EmpName
		{
			get { return empName; }
			set { empName = value; }
		}
		public virtual bool EmployeeStatus()
		{
			return true;
		}
		public virtual void ShowInfo()
		{
			Console.WriteLine("I'm in Virtual method");
		}

	}
}
