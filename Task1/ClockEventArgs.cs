using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    /// <summary>
    /// class contains additional data about event
    /// </summary>
    public sealed class ClockEventArgs:EventArgs
    {
        /// <summary>
        /// range of time through which event starts
        /// </summary>
        private int time;

        /// <summary>
        /// Property through which the field is accessed
        /// </summary>
        public int Time
        {
            private set
            {
                if (time < 0)
                    throw new ArgumentOutOfRangeException(nameof(time));
                time = value;
            }
            get { return time; }
        }

        /// <summary>
        /// Create object type of ClockEventArgs
        /// </summary>
        /// <param name="time">range of time through which event starts</param>
        public ClockEventArgs(int time)
        {
            Time = time;
        }
    }
}
