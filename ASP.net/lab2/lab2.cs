using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class lab2
    {
            public int ID;
            public string Name;
            public int Age;
            public double Weight;
            public double Height;

        public void GetCandidateDetails()
        {
            Console.Write("Enter Candidate ID: ");
            ID = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Candidate Name: ");
            Name = Console.ReadLine();

            Console.Write("Enter Candidate Age: ");
            Age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Candidate Weight (in kg): ");
            Weight = Convert.ToDouble(Console.ReadLine());

            Console.Write("Enter Candidate Height (in cm): ");
            Height = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayCandidatedetail()
        {
            {
                Console.WriteLine("Your Id is : " + ID);
                Console.WriteLine("Your Name is : " + Name);
                Console.WriteLine("Your Age is : " + Age);
                Console.WriteLine("Your Weight is : " + Weight);
                Console.WriteLine("Your Height is : " + Height);
            }
        }
    }
}
