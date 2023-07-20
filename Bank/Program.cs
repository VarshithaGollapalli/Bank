using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            string cust_name;
            int cust_phno;
            double aadhar;
            Console.WriteLine(" enter customer name, phone number and aadhar: ");
            cust_name = Console.ReadLine();
            cust_phno = Convert.ToInt32(Console.ReadLine());
            aadhar = Convert.ToDouble(Console.ReadLine());

            Console.Write("enter yr amount: ");
            double amount = Convert.ToInt32(Console.ReadLine());
            Console.Write("for how many years: ");
            int years = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Customer datails:");
            Console.WriteLine("Customer Name:" + cust_name + "\nCustomer PhoneNo: " + cust_phno + "\nCustomer Aadhar: " + aadhar);

            char bank, ch;
            do
            {
                Console.Write("Enter bank (SBI,HDFC,PNB) as (S,H,P): ");
                bank = Convert.ToChar(Console.ReadLine());
                switch (bank)
                {
                    case 'S':
                        float rate_sbi = 6.5f;
                        amount = ((amount * rate_sbi * years) / 100 + (amount));
                        Console.WriteLine("your amount accoring to SBI after" + years + "year will be " + amount + years);
                        break;
                    case 'H':
                        float rate_HDFC = 8.5f;
                        amount = ((amount * rate_HDFC * years) / 100 + (amount));
                        Console.WriteLine("your amount accoring to HDFC after" + years + "year will be " + amount + years);
                        break;
                    case 'P':
                        float rate_PNB = 5.0f;
                        amount = ((amount * rate_PNB * years) / 100 + (amount));
                        Console.WriteLine("your amount accoring to HDFC after" + years + "year will be " + amount + years);
                        break;
                    default:
                        Console.WriteLine("Invalid bank");
                        break;
                }
                Console.Write("do you want to check again(y/n): ");
                ch = bank = Convert.ToChar(Console.ReadLine());
            } while (ch == 'y');
        }
    }
}
