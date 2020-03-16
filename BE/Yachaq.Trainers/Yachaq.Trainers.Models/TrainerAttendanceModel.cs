using System;

namespace Yachaq.Trainers.Models
{
    public class TrainerAttendanceModel
    {
        public int id { get; set; }
        public int TrainerId { get; set; }
        public DateTime AttendedDay { get; set; }
        public DateTime ActualAttendance { get; set; }
        public DateTime PlannedAttendance { get; set; }

    }
}
