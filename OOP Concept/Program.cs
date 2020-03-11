using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceProvider.Inset(new Manager("PM-01", "Shuvo", "Uttara", 5));
            ServiceProvider.Inset(new Manager("PM-02", "Jahid", "Badda", 1));
            ServiceProvider.Inset(new Laborer("PL-001", "Sohan", "Mirpur", 85, 20));
            ServiceProvider.Inset(new Laborer("PL-002", "Jisan", "Kuril", 65, 44));
            ServiceProvider.Inset(new Laborer("PL-003", "Numan", "Banani", 88, 3));
            ServiceProvider.ProvideDetails();
            Console.WriteLine();

            ServiceProvider.SkilledWorker();
        }
    }
}
