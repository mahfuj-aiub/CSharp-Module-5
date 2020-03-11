using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagement
{
    static class ServiceProvider
    {
        public static  Employee[] a = new Employee[5];
        public static int i = 0;
        public static void Inset(Employee e)
        {
            a[i] = e;
            i++;
        }
        public static void ProvideDetails()
        {
            foreach(Employee e in a)
            {
                e.ShowInfo();
            }
        }
        public static void SkilledWorker()
        {
            foreach(Employee e in a)
            {
                
                if(e is Laborer l) {
                    if (l.UserRating)
                    {
                        l.ShowInfo();
                    }
                }
               
            }
        }
    }
}
