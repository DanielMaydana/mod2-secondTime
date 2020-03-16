using System;
using System.Collections.Generic;
using System.Text;

namespace Yachaq.Trainers.DTOs
{
    public class TrainerAttendanceDto
    {
        public int TrainerId { get; set; }
        public DateTime ActualAttendance { get; set; }
        public DateTime PlannedAttendance { get; set; }
    }
}
