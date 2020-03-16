using System;
using System.Linq;
using System.Collections.Generic;
using Yachaq.Trainers.DTOs;
using Yachaq.Trainers.DataAccess;
using Yachaq.Trainers.Models;

namespace Yachaq.Trainers.BusinessLogic
{
    public class AttendanceBuilder
    {
        public AttendanceBuilder()
        {
        }

        public TrainerAttendanceDto GetTimePeriodAttendance(int trainerId, DateTime startingDate, DateTime limitDate)
        {
            IRepository<TrainerAttendanceModel> attendaceRepository = new AttendanceRepository();
            IEnumerable<TrainerAttendanceModel> attendances = attendaceRepository.GetAll();

            IEnumerable<TrainerAttendanceModel> trainerAttendances = (from attended in attendances
                                                            where attended.AttendedDay >= startingDate
                                                            && attended.AttendedDay <= limitDate
                                                            && trainerId == attended.TrainerId
                                                            select new TrainerAttendanceModel {
                                                                id = attended.id,
                                                                TrainerId = attended.TrainerId,
                                                                ActualAttendance = attended.ActualAttendance,
                                                                PlannedAttendance = attended.PlannedAttendance,
                                                                AttendedDay = attended.AttendedDay
                                                            });

            double attendedHoursActual = 0;
            double attendedMinutesActual = 0;
            double attendedHoursPlanned = 0;
            double attendedMinutesPlanned = 0;
            foreach (var attendance in trainerAttendances)
            {
                attendedHoursActual += ((double)attendance.ActualAttendance.Hour);
                attendedMinutesActual += ((double)attendance.ActualAttendance.Minute);
                attendedHoursPlanned += ((double)attendance.PlannedAttendance.Hour);
                attendedMinutesPlanned += ((double)attendance.PlannedAttendance.Minute);
            }

            return new TrainerAttendanceDto
            {
                ActualAttendance = new DateTime(2000, 1, 1, (int)attendedHoursActual, (int)attendedMinutesActual, 0),
                PlannedAttendance = new DateTime(2000, 1, 1, (int)attendedHoursPlanned, (int)attendedMinutesPlanned, 0),
                TrainerId = trainerId
            };
        }

        public TrainerAttendanceDto GetWeeklyPeriodAttendance(int trainerId, DateTime limitDate)
        {
            DateTime foundDay = limitDate;
            int MONDAY = 1;

            while((int)foundDay.DayOfWeek >= MONDAY)
            {
                foundDay = foundDay.AddDays(-1);
            }

            return GetTimePeriodAttendance(trainerId, foundDay, limitDate);
        }
    }
}
