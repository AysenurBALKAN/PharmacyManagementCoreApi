using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PBusinessLayer.Concrete;
using PDataAccessLayer.Concrete;
using PDataAccessLayer.EntityFramework;
using PEntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PharmacyManagementApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        PatientManager cm = new PatientManager(new EfPatient());

        [HttpGet]
        public IActionResult PatientList()
        {
            var values = cm.TGetList();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult PatientAdd(PatientInfo t)
        {
            cm.TAdd(t);
            return Ok();
        }

        [HttpDelete ]
        public IActionResult PatientDelete(PatientInfo t)
        {
             cm.TDelete(t);
            return Ok();
        }

       [HttpPut]
        public IActionResult PatientUpdate(PatientInfo t)
        {
            cm.TUpdate(t);
            return Ok();
        }

        [HttpGet("{id}")]
        public IActionResult PatientList(int id)
        {
            var values = cm.TGetById(id);
            return Ok(values);
        }
    }
}
