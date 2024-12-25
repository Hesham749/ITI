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
        public clsDuration(int hours, int minutes, int seconds) : this(ToSeconds(hours, minutes, seconds))
        {
        }

        public static int ToSeconds(int hours, int minutes, int seconds)
        {
            return (int)(hours * Math.Pow(60, 2)) + (minutes * 60) + seconds;
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

        public static clsDuration operator +(clsDuration d1, clsDuration d2)
        {
            if (!(d1 == null && d2 == null))
                return new clsDuration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
            return null;
        }

        public static clsDuration operator -(clsDuration d1, clsDuration d2)
        {
            return d1 + d2; 
        }

        public override string ToString()
        {
            return $"{(Hours > 0 ? $"Hours: {Hours}, " : "")}{(Minutes > 0 || Hours > 0 ? $"Minutes: {Minutes}, " : "")}Seconds: {Seconds}";
        }
    }
}
