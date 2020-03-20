using System;
using System.Collections.Generic;

namespace FJala.Attendance.Models
{
    public class CalculatedAttendance
    {
        public int UserId { get; set; }
        public DateTime Date { get; set; }
        public string Location { get; set; }
        public int Minutes { get; set; }
    }
}
