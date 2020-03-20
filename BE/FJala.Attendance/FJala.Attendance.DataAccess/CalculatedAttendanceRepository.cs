using System;
using System.Collections.Generic;
using System.Text;
using FJala.Attendance.Models;

namespace FJala.Attendance.DataAccess
{
    public class CalculatedAttendanceRepository : IRepository<CalculatedAttendance>
    {
        List<CalculatedAttendance> CalculatedAttendanceList;

        public CalculatedAttendanceRepository()
        {
            this.CalculatedAttendanceList = new List<CalculatedAttendance>()
            {
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 2, 12, 0, 0), Location="Foundation", Minutes = 60},
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 4, 12, 0, 0), Location="Foundation", Minutes = 60},
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 6, 12, 0, 0), Location="Foundation", Minutes = 60},
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 9, 12, 0, 0), Location="Foundation", Minutes = 60},
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 11, 12, 0, 0), Location="Foundation", Minutes = 60},
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 13, 12, 0, 0), Location="Foundation", Minutes = 60},
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 16, 12, 0, 0), Location="Foundation", Minutes = 60},
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 17, 12, 0, 0), Location="Foundation", Minutes = 60},
                new CalculatedAttendance { UserId = 1, Date =  new DateTime(2020, 3, 17, 12, 0, 0), Location="Common", Minutes = 60}
            };
        }

        public CalculatedAttendance Get(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CalculatedAttendance> GetAll()
        {
            return this.CalculatedAttendanceList;
        }
    }
}
