using System;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Yachaq.Trainers.DTOs;
using Yachaq.Trainers.BusinessLogic;

namespace Yachaq.Trainers.Service.Controllers
{
    [Route("api")]
    [ApiController]
    public class TrainersController : ControllerBase
    {
        // GET: api/Trainers
        [Route("[controller]/{trainerId}/attendance")]
        [HttpGet("{trainerId}", Name = "GetTrainerAttendance")]
        public IActionResult GetTrainerAttendance(int trainerId, [FromQuery] DateTime startDate, [FromQuery] DateTime limitDate)
        {
            try
            {
                AttendanceBuilder builder = new AttendanceBuilder();
                TrainerAttendanceDto response;

                if (startDate == null)
                {
                    response = builder.GetWeeklyPeriodAttendance(trainerId, limitDate);
                }
                else
                {
                    response = builder.GetTimePeriodAttendance(trainerId, startDate, limitDate);
                }

                return this.StatusCode(StatusCodes.Status200OK, response);
            }
            catch(Exception error)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, error.Message);
            }
        }
    }
}
