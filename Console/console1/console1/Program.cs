using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace console1
{
    class Student_Bio
    {
        string name;
        string dateOfBirth;
        double phoneNo;
        string email_ID;
        public void getData()
        {
            Console.WriteLine("");
            Console.WriteLine("__________Enter Your Details_____________");
            Console.WriteLine("");
            Console.WriteLine("Enter student name:");
            name=Console.ReadLine();
            Console.WriteLine("Enter DOB:");
            dateOfBirth =Console.ReadLine();
            Console.WriteLine("Enter phone No:");
            phoneNo = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter emailID:");
            email_ID=Console.ReadLine();    

        }
        public void displayData()
        {
            Console.WriteLine("");
            Console.WriteLine("__________Your Details_____________");
            Console.WriteLine("");
            Console.WriteLine("Name"+name);
            Console.WriteLine("DOB:" + dateOfBirth);
            Console.WriteLine("PhoneNo:" + phoneNo);
            Console.WriteLine("Email:" + email_ID);
        }
    }

    class Student_mark:Student_Bio
    {
        int m1, m2,m3;
        public void getMark()
        {
            Console.WriteLine("");
            Console.WriteLine("__________Enter Your Marks_____________");
            Console.WriteLine("");
            Console.WriteLine("Enter Mark 1:");
            m1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark 2:");
            m2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Mark 3:");
            m3 = Convert.ToInt32(Console.ReadLine());

            displayData();
            Console.WriteLine("");
            Console.WriteLine("__________Your Persentage_____________");
            Console.WriteLine("");
            Console.WriteLine("Percentage:"+(m1+m2+m3)/3);
        }
    }
    internal class Program
    {
        
        static void Main(string[] args)
        {
             
            Student_mark student = new Student_mark();
            student.getData();
            student.getMark();
           // student.displayData();
            Console.ReadLine();
        }
    }
}
