using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Date
{
    internal class DateClass
    {
        private int year, month, day;

        public DateClass(int day, int month, int year)

        {
            this.day = day;
            this.month = month;
            this.year = year;
            Normalize();
        }

        public void Add(int days)
        {
            day +=days;
            Normalize();
        }

        public void Add(int days, int months)
        {
            day += days;
            month += months;
            Normalize();
        }


        public void Add(DateClass other)

        {
            day += other.day;
            month += other.month;
            year += other.year;
            Normalize();
        }


        private void Normalize()
        {
            while (day > 30)
            {
                day = day - 30;
                month++;
            }


            while (month > 12)
            {
                month = month -12;
                year++;
            }
        }


        public override string ToString()
        {
            return $"The date is {day}-{month}-{year}\n";
        }
    }
}

