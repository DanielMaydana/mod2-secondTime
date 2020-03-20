using System;

namespace FJala.Attendance.Common
{
    public class DailyAttendanceDetail
    {
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public string DayOfWeek { get; set; }
        public double Hours { get; set; } 
    }
}
