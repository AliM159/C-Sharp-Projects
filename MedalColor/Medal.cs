using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedalsColor
{
    public enum MedalColor
    {
        Bronze,
        Silver,
        Gold
    }


    internal class Medal
    {
        public string Name { get; }
        public string TheEvent { get; }
        public MedalColor Color { get; }
        public int Year { get; }
        public bool IsRecord { get; }

        public Medal (string name, string theEvent, MedalColor color, int year, bool isRecord)
        {
            Name = name;
            TheEvent = theEvent;
            Color = color;
            Year = year;
            IsRecord = isRecord;
        }


        public override string ToString()
        {
            string recordCheck;
            if (IsRecord)
            {
                recordCheck = "(R)";
            } 
            else
            {
                recordCheck = "";
            }
                return $"{Year} - {TheEvent}{recordCheck} {Name}({Color})";
        }
    }
}
