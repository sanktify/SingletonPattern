using System;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
               () => PrintStudentDetails(), 
                () => PrintEmployeeDetails()
                );
            Console.ReadLine();
        }

        private static void PrintStudentDetails()
        {
            Singleton sobj = Singleton.Instance;
            sobj.DisplayValues("this is from Student class");
        }

        private static void PrintEmployeeDetails()
        {
            Singleton eobj = Singleton.Instance;
            eobj.DisplayValues("this is from Employee class");
        }
    }
}
