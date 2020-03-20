using System;
using System.Collections.Generic;
using System.Text;
using FJala.Attendance.Models;

namespace FJala.Attendance.DataAccess
{
    public class PeriodAttendanceRepository : IRepository<PeriodAttendance>
    {
        private List<PeriodAttendance> PeriodAttendances;
        public PeriodAttendanceRepository()
        {
            this.PeriodAttendances = new List<PeriodAttendance>
            {
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 4, 9, 0, 0), Direction = "in"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 4, 10, 0, 0), Direction = "out"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 6, 9, 0, 0), Direction = "in"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 6, 10, 0, 0), Direction = "out"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 9, 9, 0, 0), Direction = "in"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 9, 10, 0, 0), Direction = "out"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 11, 9, 0, 0), Direction = "in"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 11, 10, 0, 0), Direction = "out"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 13, 9, 0, 0), Direction = "in"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 13, 10, 0, 0), Direction = "out"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 16, 9, 0, 0), Direction = "in"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 16, 10, 0, 0), Direction = "out"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 17, 9, 0, 0), Direction = "in"},
                new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 17, 10, 0, 0), Direction = "out"}
                //new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 17, 11, 0, 0), Direction = "in"},
                //new PeriodAttendance { UserId = 1, Date = new DateTime(2020, 3, 17, 12, 0, 0), Direction = "out"},
            };
        }

        public PeriodAttendance Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<PeriodAttendance> GetAll()
        {
            return this.PeriodAttendances;
        }
    }
}
