using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Staff
    {
        
        public string Name;
        public string Department;
        public string Designation;
        public int Experiense;
        public int Salary;

        public void GetDetailOfStaff()
        {
           
                Console.Write("Enter Staff Name: ");
                Name = Console.ReadLine();

                Console.Write("Enter  Department: ");
                Department = Console.ReadLine();

                Console.Write("Enter Designation: ");
                Designation = Console.ReadLine();

                Console.Write("Enter Experiense in number: ");
                Experiense = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Salary in number: ");
                Salary = Convert.ToInt32(Console.ReadLine());
            
        }
        public void DisplayStaffDetail()
         {
            
           
                Console.WriteLine("Name is : " + Name);
                Console.WriteLine("Salary is : " + Salary);
            
        }


    }
}
