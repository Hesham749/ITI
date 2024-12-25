using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Duration
{
    internal class clsDuration
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public clsDuration(int seconds)
        {
            SetSeconds(seconds);
        }
        public clsDuration(int hours, int minutes, int seconds)
        {
            SetHours(hours);
            SetMinutes(minutes);
            SetSeconds(seconds);
        }



        public bool SetSeconds(int seconds)
        {
            if (seconds < 0)
                return false;
            if (seconds >= 60)
            {
                Minutes += seconds / 60;
                SetMinutes(Minutes);
                Seconds = seconds % 60;
            }
            else
                Seconds = seconds;
            return true;
        }

        public bool SetMinutes(int minutes)
        {
            if (minutes < 0)
                return false;
            if (minutes >= 60)
            {
                Hours += (minutes / 60);
                Minutes = minutes % 60;
            }
            else
                Minutes = minutes;
            return true;
        }

        public bool SetHours(int hours)
        {
            if (hours < 0)
                return false;
            Hours = hours;
            return true;
        }

        public override string ToString()
        {
            return $"{(Hours > 0 ? $"Hours: {Hours}, " : "")}{(Minutes > 0 || Hours > 0 ? $"Minutes: {Minutes}, " : "")}Seconds: {Seconds}";
        }
    }
}
