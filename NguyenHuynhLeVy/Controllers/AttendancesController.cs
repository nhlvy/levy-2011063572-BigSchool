using Microsoft.AspNet.Identity;
using Microsoft.VisualBasic.ApplicationServices;
using NguyenHuynhLeVy.DTOs;
using NguyenHuynhLeVy.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NguyenHuynhLeVy.Controllers
{
    [Authorize]
    public class AttendancesController : ApiController
    {


        private ApplicationDbContext _dbContext;

        public AttendancesController()
        {
            _dbContext = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult Attend(AttendanceDto attendanceDto)
        {
            var userId = User.Identity.GetUserId();
            if (_dbContext.Attendences.Any(a => a.AttendeeId == userId && a.CourseId == attendanceDto.CourseId))
                return BadRequest("The Attendance already exitsts");

            var attendance = new Attendance
            {
                CourseId = attendanceDto.CourseId,
                AttendeeId = userId
            };

            _dbContext.Attendences.Add(attendance);
            _dbContext.SaveChanges();

            return Ok();
        }

    }

}
