namespace AttendanceService.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using Attendance.DTO;

    [ApiController]
    public class AttendanceController : ControllerBase
    {
        [Route("api/[controller]/current/")]
        [HttpGet]
        public CurrentAttendanceDTO GetCurrentAttendance(int id)
        {
            CurrentAttendanceDTO currentAttendance = new CurrentAttendanceDTO()
            {
                HoursAttended = 2.0,
                HoursUntilDate = 8.0,
                CompletionPercentage = 25
            };

            return currentAttendance;
        }

        [Route("api/[controller]/weekly/")]
        [HttpGet]
        public OverallAttendanceDTO GetOverallAttendance(int id)
        {
            OverallAttendanceDTO overallAttendance = new OverallAttendanceDTO()
            {
                HoursAttended = 2.0,
                TotalWeekHours = 2.0,
                CompletionPercentage = 100
            };

            return overallAttendance;
        }
    }
}
