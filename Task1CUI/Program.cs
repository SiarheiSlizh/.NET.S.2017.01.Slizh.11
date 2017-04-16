using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1CUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();

            Client1 client1 = new Client1();
            Client2 client2 = new Client2();
            Client3 client3 = new Client3();

            client1.Register(clock);
            client3.Register(clock);

            clock.DoNotification(5);

            Console.WriteLine("*****");

            client1.Unregister(clock);
            client2.Register(clock);

            clock.DoNotification(3);
        }
    }
}
