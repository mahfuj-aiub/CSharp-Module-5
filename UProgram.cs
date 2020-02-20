using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class UProgram
    {
        private string programName, programHead;
        private Degree degree;
        public UProgram(string pName, string pHead)
        {
            this.programName = pName;
            this.programHead = pHead;

        }
        public Degree DegreeName
        {
            get { return this.degree; }
            set { this.degree = value; }
        }
        public string pName
        {
            get { return this.programName; }
        }
    }
}
