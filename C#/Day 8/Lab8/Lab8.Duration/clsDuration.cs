namespace Lab8.Duration
{
    internal class ClsDuration
    {
        public int Hours { get; private set; }
        public int Minutes { get; private set; }
        public int Seconds { get; private set; }

        public ClsDuration(int seconds)
        {
            SetSeconds(seconds);
        }

        public ClsDuration(int hours, int minutes, int seconds) : this(ToSeconds(hours, minutes, seconds))
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

        #region +
        public static ClsDuration operator +(ClsDuration d1, ClsDuration d2)
        {
            if (!(d1 == null && d2 == null))
                return new ClsDuration(d1.Hours + d2.Hours, d1.Minutes + d2.Minutes, d1.Seconds + d2.Seconds);
            return null;
        }

        public static ClsDuration operator +(ClsDuration d1, int x)
        {

            return d1 + new ClsDuration(x);

        }

        public static ClsDuration operator +(int x, ClsDuration d1)
        {

            return d1 + new ClsDuration(x);

        }

        public static ClsDuration operator ++(ClsDuration c)
        {
            return c + new ClsDuration(60);
        }
        #endregion

        #region -
        public static ClsDuration operator -(ClsDuration d1, ClsDuration d2)
        {
            if (!(d1 == null && d2 == null))
                return new ClsDuration(d1.Hours - d2.Hours, d1.Minutes - d2.Minutes, d1.Seconds - d2.Seconds);
            return null;
        }


        public static ClsDuration operator -(ClsDuration d1, int x)
        {

            return d1 - new ClsDuration(x);

        }

        public static ClsDuration operator -(int x, ClsDuration d1)
        {

            return d1 - new ClsDuration(x);

        }

        public static ClsDuration operator --(ClsDuration c)
        {
            return c - new ClsDuration(60);
        }
        #endregion

        #region ><
        public static bool operator >(ClsDuration d1, ClsDuration d2)
        {
            if (!(d1 == null && d2 == null))
                return (ToSeconds(d1.Hours, d1.Minutes, d1.Minutes) > ToSeconds(d2.Hours, d2.Minutes, d2.Minutes));
            return false;
        }

        public static bool operator <(ClsDuration d1, ClsDuration d2)
        {
            if (!(d1 == null && d2 == null))
                return (ToSeconds(d1.Hours, d1.Minutes, d1.Minutes) < ToSeconds(d2.Hours, d2.Minutes, d2.Minutes));
            return false;
        }

        #endregion

        #region >=<=
        public static bool operator >=(ClsDuration d1, ClsDuration d2)
        {
            if (!(d1 == null && d2 == null))
                return (ToSeconds(d1.Hours, d1.Minutes, d1.Minutes) >= ToSeconds(d2.Hours, d2.Minutes, d2.Minutes));
            return false;
        }

        public static bool operator <=(ClsDuration d1, ClsDuration d2)
        {
            if (!(d1 == null && d2 == null))
                return (ToSeconds(d1.Hours, d1.Minutes, d1.Minutes) <= ToSeconds(d2.Hours, d2.Minutes, d2.Minutes));
            return false;
        }

        #endregion

        public override string ToString()
        {
            return $"{(Hours > 0 ? $"Hours: {Hours}, " : "")}{(Minutes > 0 || Hours > 0 ? $"Minutes: {Minutes}, " : "")}Seconds: {Seconds}";
        }
    }
}
