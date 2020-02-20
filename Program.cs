using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module5
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Mahfujur", "Rahman", "23-10-1997", "Kishoreganj", "Motijeel", "Dhaka", "Dhaka", "Bangladesh");
            Student s2 = new Student("Tabiul", "Hasan", "16-12-1999", "Comilla", "Mohammadpur", "Dhaka", "Dhaka", "Bangladesh");
            Student s3 = new Student("Fatima", "Jahan", "15-10-1990", "Noagoan", "Basundara", "Dhaka", "Dhaka", "Bangladesh");
            Course c1 = new Course("Programming With C#", 3, 6);
            c1[0] = s1;
            c1[1] = s2;
            c1[2] = s3;
            Teacher t1 = new Teacher("Habibur", "Rahman", "15-02-1969", "Kishoreganj", "Dhaka", "Unknown", "Unknown", "Bangladesh");
            c1['0'] = t1;
            Degree d = new Degree("Bachelor", 148);
            d.CourseName = c1;
            UProgram up = new UProgram("Information Technology", "Mahfujur Rahman");
            up.DegreeName = d;
            Console.WriteLine("The {0} program contains the {1} of science degree", up.pName, up.DegreeName.dName);
            Console.WriteLine("The {0} of science degree contains the course {1}", up.DegreeName.dName, up.DegreeName.CourseName.CourseName);
            Console.WriteLine("The {0} course contains with {1} {2}", up.DegreeName.CourseName.CourseName, up.DegreeName.CourseName[0].TotalStudent, c1[0].GetType().Name);




        }
    }
}
