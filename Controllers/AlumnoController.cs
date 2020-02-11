using System;
using System.Linq;

using Microsoft.AspNetCore.Mvc;
using spa.Models;
using spa.Services.Interface;

namespace GenericProjectBase.Controllers
{
    [Route("api/Alumno/")]
    public class AlumnoController : Controller
    {
        private readonly IServicesAlumno _AlumnoService;

        public AlumnoController(IServicesAlumno AlumnoService)
        {
            _AlumnoService = AlumnoService;
        }

        [Route("getAll")]
        public IQueryable<Alumno> Get()
        {
            return _AlumnoService.GetAll();
        }

        [Route("save")]
        [HttpPost]
        public Alumno Save([FromBody] Alumno Alumno)
        {
            return _AlumnoService.Save(Alumno);
        }

        [Route("delete")]
        [HttpDelete]
        public Alumno DeleteByName([FromQuery] string name)
        {
            return _AlumnoService.DeleteByName(name);
        }

        [Route("getById")]
        [HttpGet]
        public Alumno GetById([FromQuery] Guid id)
        {
            return _AlumnoService.GetById(id);
        }
    }
}

