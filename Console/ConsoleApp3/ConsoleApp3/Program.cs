using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{

    class Student_BioData

    {

        string name;

        string dateOfBirth;

        double phoneNumber;

        string e_mailId;

        public void getData()

        {

            Console.WriteLine("Enter student Name");

            name = Console.ReadLine();

            Console.WriteLine("Enter Student Date Of Birth");

            dateOfBirth = Console.ReadLine();

            Console.WriteLine("Enterstudent Phone Number");

            phoneNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Student E_Mail ID");

            e_mailId = Console.ReadLine();

        }

        public void displayData()

        {

            Console.WriteLine("Student Name :" + name);

            Console.WriteLine("Student Date Of Birth :" + dateOfBirth);

            Console.WriteLine("Student Phone Number :" + phoneNumber);

            Console.WriteLine("Student E_Mail ID :" + e_mailId);

        }

    }

    class student_Marks : Student_BioData

    {

        int mark1, mark2, mark3, Percentage;

        public void getMark()

        {

            Console.WriteLine("Enter Mark1");

            mark1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mark2");

            mark2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mark3");

            mark3 = Convert.ToInt32(Console.ReadLine());

        }

        public void displayResult()

        {

            Percentage = (mark1 + mark2 + mark3) / 3;

            displayData();

            Console.WriteLine("Result in Percentage :" + Percentage);

        }

    }

    class Program

    {

        static void Main(string[] args)

        {

            student_Marks obj = new student_Marks();

            obj.getData();

            obj.getMark();

            obj.displayResult();

            Console.Read();

        }

    }
}
