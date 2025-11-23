using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Times
{
    enum TimeFormat
    {
        Mil,
        Hour12,
        Hour24
    }

    internal class Time
    {
        private static TimeFormat TIME_FORMAT = TimeFormat.Hour12;
        public int Hour { get; }
        public int Minute { get; }


        public Time(int hour = 0, int minute = 0)
        {
            if (hour >= 0 && hour <= 24)
            {
                Hour = hour;
            }
            else 
            {
                Hour = 0;
            }

            if (minute >= 0 && minute <= 60)
            {
                Minute = minute;
            }
            else
            {
                Minute = 0;
            }
        }




        public static void SetFormat(TimeFormat format)
        {
            TIME_FORMAT = format;
        }


        public override string ToString()
        {
            switch (TIME_FORMAT)
                {
                 case TimeFormat.Mil:
                    return $"{Hour:D2}{Minute:D2}";


                 case TimeFormat.Hour24:
                    return $"{Hour:D2}:{Minute:D2}";


                case TimeFormat.Hour12:
                    string amPm = (Hour < 12) ? "AM" : "PM";
                    int hour12 = Hour % 12;
                    if (hour12 == 0)
                        hour12 = 12;
                    return $"{hour12:D2}:{Minute:D2} {amPm}";


                default:
                    return "Did not enter a valid format";
                }



            
        }

    }
}

