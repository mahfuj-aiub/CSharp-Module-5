using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Student
    {
        private string firstName, lastName, birthdate, address1, address2, city, state, country;
        private static int countStudent;
        public Student(string fName, string lName, string DOB, string add1, string add2, string city, string state, string country)
        {
            this.firstName = fName;
            this.lastName = lName;
            this.birthdate = DOB;
            this.address1 = add1;
            this.address2 = add2;
            this.city = city;
            this.state = state;
            this.country = country;
            countStudent++;

        }
        public int TotalStudent
        {
            get { return countStudent; }
        }
    }
}
