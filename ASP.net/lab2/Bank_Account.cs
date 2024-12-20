using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lab2
{
    internal class Bank_Account
    {
        public int Account_No;
        public string Email;
        public string User_Name;
        public string Account_Type;
        public double Account_Balance;
    
     public void GetAccountDetails()
        {
            Console.Write("Enter Account_No ");
            Account_No = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Email: ");
            Email = Console.ReadLine();

            Console.Write("Enter Name: ");
            User_Name = Console.ReadLine();

            Console.Write("Enter Account Type: ");
            Account_Type = (Console.ReadLine());

            Console.Write("Enter Balance: ");
            Account_Balance = Convert.ToDouble(Console.ReadLine());
        }
        public void DisplayAccountdetail()
        {
            
                Console.WriteLine("Your Account No is : " + Account_No);
                Console.WriteLine("Your Email is : " + Email);
                Console.WriteLine("Your Name is : " + User_Name);
                Console.WriteLine("Your Account Type is : " + Account_Type);
                Console.WriteLine("Your Account balance is : " + Account_Balance);
        }
        }
    }
