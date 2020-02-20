using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Degree
    {
        private string degreeName;
        private int creditReq;
        private Course course;
        public Degree(string dName, int Cr)
        {
            this.degreeName = dName;
            this.creditReq = Cr;
        }
        public Course CourseName
        {
            get { return this.course; }
            set
            {
                this.course = value;
            }

        }
        public string dName
        {
            get { return this.degreeName; }
        }
    }
}
