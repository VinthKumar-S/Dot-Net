using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSale
{
    public interface Bill
    {
        void display();
    }
    public class Calculate : Bill
    {
        int custid, conu;      
        double chg, surchg = 0, gramt, netamt;
        string connm;
        public void getdata()
        {
            Console.Write("\n\n");
            Console.Write("Calculate Electricity Bill:\n");
            Console.Write(" ");
            Console.Write("\n\n");
            Console.Write("Input Customer ID :");
            custid = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the name of the customer :");
            connm = Console.ReadLine();
            Console.Write("Input the unit consumed by the customer : ");
            conu = Convert.ToInt32(Console.ReadLine());
        }
        public void calculateBill()
        {
            if (conu < 200)
                chg = 1.20;
            else if (conu >= 200 && conu < 400)
                chg = 1.50;
            else if (conu >= 400 && conu < 600)
                chg = 1.80;
            else
                chg = 2.00;
            gramt = conu * chg;
            if (gramt > 300)
                surchg = gramt * 15 / 100.0;
            netamt = gramt + surchg;
            if (netamt < 100)
                netamt = 100;
        }       
        public void display()
        {
            Console.Write("Customer IDNO :{0}\n", custid); 
           // Console.Write("CustomerName:{ 0}\n", connm); 
           // Console.Write("unit Consumed :{ 0}\n", conu+"");
            Console.Write("Amount Charges @Rs. {0} per unit :{1}\n", chg, gramt);
            Console.Write("Surchage Amount :{0}\n", surchg); 
           // Console.Write("NetAmount Paid By the Customer:{ 0}\n", netamt+""); 
        }
}
        public class BasicInformation : Bill
        {
            public void display()
            {
                Console.Write("\n\n");
                Console.Write("Electricity Bill Tariff:\n");
                Console.Write(" ");
                Console.Write("\n\n");
                Console.WriteLine("upto 199 @1.20");
                Console.WriteLine("200 and above but less than 400 @1.50");
                Console.WriteLine("400 and above but less than 600 @1.80");
                Console.WriteLine("600 and above @2.00");
                Console.WriteLine("If bill exceeds Rs. 400 then a surcharge of 15%will becharged and the minimum bill should be of Rs. 100 / -"); } }
            internal class Program
    {
        static void Main(string[] args)
        {
            Calculate obj1 = new Calculate();
            obj1.getdata();
            obj1.calculateBill();
            obj1.display();
            BasicInformation obj2 = new BasicInformation();
            obj2.display();
            Console.Read();
        }
    }
}
