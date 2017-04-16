using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// Class simulates countdown clock
    /// </summary>
    public sealed class Clock
    {
        /// <summary>
        /// Event which is based on delegate EventHandler
        /// </summary>
        public event EventHandler<ClockEventArgs> Notification = delegate { };

        /// <summary>
        /// Event start
        /// </summary>
        /// <param name="e">this class contains additional data about event</param>
        private void OnNotification(ClockEventArgs e) => Notification?.Invoke(this, e);

        /// <summary>
        /// Method starts thr event at the end of time
        /// </summary>
        /// <param name="time">range of time through which event starts.</param>
        public void DoNotification(int time)
        {
            ClockEventArgs timeToNotify = new ClockEventArgs(time);
            Thread.Sleep(time * 1000);
            OnNotification(timeToNotify);
        }
    }
}
