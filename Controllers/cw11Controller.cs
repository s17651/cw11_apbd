using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using APBD_c11.Models;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace APBD_c11.Controllers
{
    [Route("api/cw11")]
    [ApiController]
    public class cw11Controller : ControllerBase
    {
        private readonly cw11DbContext _context;
        public cw11Controller(cw11DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("doctors")]
        public IActionResult GetDoctors() 
        {
            List<Doctor> result = _context.Doctors.ToList();
            return Ok(result);
        }

        [HttpPost]
        [Route("doctors")]
        public IActionResult AddDoctor(Doctor doc) {

            _context.Add(doc);
            _context.SaveChanges();
            return Ok();
            
        }

        [HttpDelete]
        [Route("doctors/{id}")]
        public IActionResult DeleteDoctor(int id) {
            Doctor doctor = new Doctor
            {
                IdDoctor = id
            };

            _context.Attach(doctor);
            _context.Remove(doctor);
            _context.SaveChanges();
            return Ok();
        }
        [HttpPut]
        [Route("doctors/")]
        public IActionResult ModifyDoctor(Doctor doctor)
        {
            
            _context.Attach(doctor);
            _context.Entry(doctor).State = EntityState.Modified;
            _context.SaveChanges();
            return Ok();
        }
    }
}