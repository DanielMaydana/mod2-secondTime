using System;
using System.Linq;
using System.Collections.Generic;
using FJala.Attendance.DTOs;
using FJala.Attendance.Models;
using FJala.Attendance.DataAccess;
using FJala.Attendance.Common;

namespace FJala.Attendance.BusinessLogic
{
    public class AttendanceBuilder
    {

        public CompleteAttendanceDTO GetTodayAttendance(int id)
        {
            DateTime today = new DateTime(2020, 3, 17);
            DateTime startingDate = today;
            DateTime endDate = today;

            CalculatedAttendanceRepository calculatedRepository = new CalculatedAttendanceRepository();
            PeriodAttendanceRepository periodRepository = new PeriodAttendanceRepository();
            IEnumerable<CalculatedAttendance> calculatedAttendances = calculatedRepository.GetAll();
            IEnumerable<PeriodAttendance> periodAttendances = periodRepository.GetAll();

            var inRangePeriodAttendances = (from attend in periodAttendances
                                            where attend.Date.Day == startingDate.Day
                                            select new PeriodAttendance
                                            {
                                                Date = attend.Date,
                                                Direction = attend.Direction,
                                                UserId = attend.UserId
                                            });

            var inRangeCalculatedAttendances = (from attend in calculatedAttendances
                                                where attend.Date.Day == startingDate.Day
                                                select new CalculatedAttendance
                                                {
                                                    Date = attend.Date,
                                                    Minutes = attend.Minutes,
                                                    Location = attend.Location,
                                                    UserId = attend.UserId
                                                });

            List<Tuple<DateTime?, DateTime?>> periodsAsPairs = GenerateStartEndPairs(inRangePeriodAttendances);
            
            double hoursFromPeriods = this.GetTotalHoursInPeriodRange(periodsAsPairs);

            CalculatedAttendance calculated = inRangeCalculatedAttendances.First();

            double calculatedHours = (double)calculated.Minutes / 60;

            string username = "Pablo";

            return new CompleteAttendanceDTO
            {
                UserName = username,
                StartDate = startingDate,
                EndDate = endDate,
                DetailPerDay = new List<DailyAttendanceDetail>
                {
                    new DailyAttendanceDetail
                    {
                        Location = calculated.Location,
                        Date = startingDate,
                        DayOfWeek = startingDate.ToString("ddd"),
                        Hours = hoursFromPeriods  + calculatedHours
                    }
                }

            };
        }

        private List<Tuple<DateTime?, DateTime?>> GenerateStartEndPairs(IEnumerable<PeriodAttendance> inRangePeriodAttendances)
        {
            List<Tuple<DateTime?, DateTime?>> periods = new List<Tuple<DateTime?, DateTime?>>();

            foreach (var attendance in inRangePeriodAttendances)
            {
                if (periods.Count != 0)
                {
                    var lastIndex = periods.Count - 1;
                    if (attendance.Direction == "in")
                    {
                        Tuple<DateTime?, DateTime?> period = Tuple.Create<DateTime?, DateTime?>(attendance.Date, null);
                        periods.Add(period);
                    }
                    if (attendance.Direction == "out" && periods[lastIndex].Item2 == null)
                    {
                        periods[lastIndex] = Tuple.Create<DateTime?, DateTime?>(periods[lastIndex].Item1, attendance.Date);
                    }
                }
                else
                {
                    Tuple<DateTime?, DateTime?> startingPeriod = Tuple.Create<DateTime?, DateTime?>(attendance.Date, null);
                    periods.Add(startingPeriod);
                }
            }

            return periods;
        }

        private double GetTotalHoursInPeriodRange(List<Tuple<DateTime?, DateTime?>> periods)
        {
            double totalHoursPerPeriod = 0;

            foreach (var period in periods)
            {
                TimeSpan span = (DateTime)period.Item2 - (DateTime)period.Item1;
                totalHoursPerPeriod += span.TotalHours;
            }

            return totalHoursPerPeriod;
        }
    }
}
