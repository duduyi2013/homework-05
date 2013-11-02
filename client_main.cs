using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NB1111
{
    class Program
    {
        public static void Main()
        {


            client[] a = new client[20];
            for (int i = 0; i < 20; i++)
            {
                a[i] = new client { sname = "c-" + i.ToString(), scode = "123" };
                a[i].connnectserver();
                a[i].Sign_Receive();
                a[i].Regester();
            }

            Console.ReadLine();
        }
    }
}
