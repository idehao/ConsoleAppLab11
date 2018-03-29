using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // create the employee array
            Employee[] employeeArray = new Employee[3];
            // populate with some data
            employeeArray[0] = new Employee { FirstName = "Jesse", LastName = "Liberty" };
            employeeArray[1] = new Employee { FirstName = "John", LastName = "Smith" };
            employeeArray[2] = new Employee { FirstName = "Mary", LastName = "Liu" };
            // display values on the screen
            for (int i = 0; i < employeeArray.Length; i++) {
                Console.WriteLine(employeeArray[i]);
            }

            Console.Read();
        }
    }
}
