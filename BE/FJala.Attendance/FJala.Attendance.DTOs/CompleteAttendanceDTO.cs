using System;
using System.Collections.Generic;
using FJala.Attendance.Common;

namespace FJala.Attendance.DTOs
{
    public class CompleteAttendanceDTO
    {
        public string UserName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        public IEnumerable<DailyAttendanceDetail> DetailPerDay { get; set; }
    }
}
