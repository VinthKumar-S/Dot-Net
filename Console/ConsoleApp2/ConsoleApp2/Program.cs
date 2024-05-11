using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public interface Bill
    {
        void display();
    }

    public class Calculate : Bill
    {
        int cusid, conu;
        double chg, surchg = 0, grant, netamt;
        string connm;

        public void getdata()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("Calculate Elericity Bill:\n");
            Console.WriteLine("----------------------------");
            Console.WriteLine("\n\n");
            Console.WriteLine("Input Customer ID");
            cusid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input the unit consumed by the customer :");
            conu = Convert.ToInt32(Console.ReadLine());
        }

        public void calculateBill()
        {
            if (conu < 200)
                chg = 1.20;
            else if (conu >=200 && conu < 400)
                chg = 1.50;
            else if (conu >= 400 && conu< 600)
                chg = 1.80;
            else 
                chg = 2.00;
            grant = conu * chg;
            if(grant <300)
                surchg = grant*15/100.0;
            netamt = grant + surchg;
            if(netamt <100)
                netamt = 100;


        }
        public void display() 
        {
            Console.WriteLine("Customer IDNO :{0}\n", cusid);
            Console.WriteLine("Customer Name :{0}\n", connm);
            Console.WriteLine("unit Consumed :{0}\n", conu);
            Console.WriteLine("Amount Charges @ Rs. {0} per unit :{1}\n", chg, grant);
            Console.WriteLine("Surchage Amount :{0}\n", surchg);
            Console.WriteLine("Net Amount Paid By the Customer:{0}\n", netamt);
        }
    }

    public class BasicInformation : Bill
    {
        public void display()
        {
            Console.Write("\n\n");
            Console.WriteLine("Electricity Bill Tariff:\n");
            Console.WriteLine("..........................");
            Console.WriteLine("\n\n");
            Console.WriteLine("upto 199 @ 1.20");
            Console.WriteLine("200 and above but less than 400 @1.50");
            Console.WriteLine("400 and above but less than 600 @1.80");
            Console.WriteLine("600 and above @2.00");
            Console.WriteLine("if bill exceeds Rs.400 then surcharge of 15 % will be charged and the minimum bill should be of Rs. 100/-");

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Calculate calculate = new Calculate();
            calculate.getdata();
            calculate.calculateBill();
            calculate.display();
            BasicInformation basicInformation = new BasicInformation(); 
            basicInformation.display();
            Console.Read();
        }
    }
}
