using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Course
    {
        private string courseName;
        private int credits;
        private int hours;
        private Student[] studentList = new Student[3];
        private Teacher[] teacherList = new Teacher[3];
        public Course(string cName, int cr, int hours)
        {
            this.courseName = cName;
            this.credits = cr;
            this.hours = hours;
        }
        public Student this[int index]
        {
            get { return this.studentList[index]; }
            set { this.studentList[index] = value; }
        }
        public Teacher this[char i]
        {

            get
            {
                int index = i - 48;
                return this.teacherList[index];
            }
            set
            {
                int index = i - 48;
                this.teacherList[index] = value;
            }
        }
        public string CourseName
        {
            get { return this.courseName; }
        }


    }
}
