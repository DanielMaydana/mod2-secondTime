using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using FJala.Attendance.BusinessLogic;
using FJala.Attendance.DTOs;

namespace FJala.Attendance.Service.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttendancesController : ControllerBase
    {
        // GET: api/Attendances
        [HttpGet]
        [Route("today")]

        public IActionResult Get()
        {
            try
            {
                AttendanceBuilder builder = new AttendanceBuilder();
                CompleteAttendanceDTO response = builder.GetTodayAttendance(1);
                return this.StatusCode(StatusCodes.Status200OK, response);
            }
            catch (Exception error)
            {
                return this.StatusCode(StatusCodes.Status500InternalServerError, error.Message);
            }

        }
    }
}
