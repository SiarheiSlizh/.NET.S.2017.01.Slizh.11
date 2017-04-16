using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1;

namespace Task1CUI
{
    public class Client1
    {
        public void Register(Clock clock) => clock.Notification += Info;

        public void Unregister(Clock clock) => clock.Notification -= Info;

        private void Info(object sender, ClockEventArgs e) => Console.WriteLine($"Order for client 1 is accepted.\n It takes {e.Time} seconds.");
    }

    public class Client2
    {
        public void Register(Clock clock) => clock.Notification += Info;

        public void Unregister(Clock clock) => clock.Notification -= Info;

        private void Info(object sender, ClockEventArgs e) => Console.WriteLine($"Order for client 2 is accepted.\n It takes {e.Time} seconds.");
    }

    public class Client3
    {
        public void Register(Clock clock) => clock.Notification += Info;

        public void Unregister(Clock clock) => clock.Notification -= Info;

        private void Info(object sender, ClockEventArgs e) => Console.WriteLine($"Order for client 3 is accepted.\n It takes {e.Time} seconds.");
    }
}
