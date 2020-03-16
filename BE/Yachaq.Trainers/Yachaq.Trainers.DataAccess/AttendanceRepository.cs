using System;
using System.Collections.Generic;
using Yachaq.Trainers.Models;

namespace Yachaq.Trainers.DataAccess
{
    public class AttendanceRepository : IRepository<TrainerAttendanceModel>
    {
        public TrainerAttendanceModel Get(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<TrainerAttendanceModel> GetAll()
        {
            IEnumerable<TrainerAttendanceModel> mockCollection = new List<TrainerAttendanceModel>
            {
                new TrainerAttendanceModel{ id = 1, TrainerId = 1, AttendedDay = new DateTime(2020, 3, 16), ActualAttendance = new DateTime(2000, 1, 1, 1, 0, 0), PlannedAttendance = new DateTime(2000, 1, 1, 2, 0, 0)},
                new TrainerAttendanceModel{ id = 2, TrainerId = 1, AttendedDay = new DateTime(2020, 3, 17), ActualAttendance = new DateTime(2000, 1, 1, 1, 0, 0), PlannedAttendance = new DateTime(2000, 1, 1, 2, 0, 0)},
                new TrainerAttendanceModel{ id = 3, TrainerId = 1, AttendedDay = new DateTime(2020, 3, 18), ActualAttendance = new DateTime(2000, 1, 1, 2, 0, 0), PlannedAttendance = new DateTime(2000, 1, 1, 2, 0, 0)},
                new TrainerAttendanceModel{ id = 4, TrainerId = 1, AttendedDay = new DateTime(2020, 3, 19), ActualAttendance = new DateTime(2000, 1, 1, 2, 0, 0), PlannedAttendance = new DateTime(2000, 1, 1, 2, 0, 0)}
            };
            return mockCollection;
        }
    }
}
