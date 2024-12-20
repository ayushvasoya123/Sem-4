using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    internal class Student
    {
        public string Enrollment_No;
        public string Student_Name;
        public int Semester;
        public double CPI;
        public double SPI;

        

        public Student(string enrollment_no, string student_name, int semester, double cpi,double spi)
        {
            Enrollment_No = enrollment_no;
            Student_Name = student_name;
            Semester = semester;
            CPI = cpi;
            SPI = spi;
        }
    public void DisplayStudentDetails()
        {
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Enrollment_No is : "+Enrollment_No);
            Console.WriteLine("Student_Name is : "+Student_Name);
            Console.WriteLine("Semester is : " + Semester);
            Console.WriteLine("CPI is : " + CPI);
            Console.WriteLine("SPI is : " + SPI);
        }
    }
}
