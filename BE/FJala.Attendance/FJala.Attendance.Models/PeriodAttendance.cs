using System;
using System.Collections.Generic;
using System.Text;

namespace FJala.Attendance.Models
{
    public class PeriodAttendance
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Direction { get; set; }
    }
}
