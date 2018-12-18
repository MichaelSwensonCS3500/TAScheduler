using System;
using System.Collections.Generic;

namespace Teaching_Assistant
{
    public class Labs
    {
        private readonly DayOfWeek labDay;
        public DayOfWeek LabDay { get => labDay; }
        private TimeSpan startTime;
        private TimeSpan endTime;
        private int ID;

        public override string ToString()
        {
            return String.Format("Lab: {0,-4} {1,-15} Start {2,-16} End {3,-16}", ID, labDay.ToString(), startTime.ToString(@"hh\:mm"), endTime.ToString(@"hh\:mm"));
        }

        public Labs(DayOfWeek day, TimeSpan startTime, TimeSpan endTime, int labID)
        {
            this.startTime = startTime;
            this.endTime = endTime;
            labDay = day;
            ID = labID;
        }

    }
}