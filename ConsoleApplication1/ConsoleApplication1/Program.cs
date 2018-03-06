using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
namespace ConsoleApplication1
{
    class Program
    {
        static void nsLookup()
        {

            Console.WriteLine("nhap ten mien or IP: ");
            string a = Console.ReadLine();
            IPHostEntry entry = Dns.Resolve(a);
            Console.WriteLine("hostname : " + entry.HostName);
            Console.WriteLine("ip: " + entry.AddressList[0]);
        }
        static void Main(string[] args)
        {
            // Bai 1
            //String strHostName = Dns.GetHostName();
            //Console.WriteLine("Host Name: " + strHostName);

            //// Find host by name
            //IPHostEntry iphostentry = Dns.GetHostByName(strHostName);

            //// Enumerate IP addresses
            //int nIP = 0;
            //foreach (IPAddress ipaddress in iphostentry.AddressList)
            //{
            //    Console.WriteLine("IP #" + ++nIP + ": " +
            //                      ipaddress.ToString());
            //}
            //Console.ReadLine();


            //bai 2
            nsLookup();
            Console.ReadLine();
            
        }
    }
}
