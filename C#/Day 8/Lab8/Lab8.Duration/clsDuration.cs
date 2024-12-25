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

        //public clsDuration(int seconds = 0)
        //{

        //}
        public clsDuration(int hours, int minutes, int seconds = 0)
        {
            Hours = 0;
            Minutes = 0;
            Seconds = 0;
            SetHours(hours);
            SetMinutes(minutes);
        }



        //public bool SetSeconds(int seconds)
        //{

        //}

        public bool SetMinutes(int minutes)
        {
            if (minutes < 0)
                return false;
            if (minutes > 60)
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
