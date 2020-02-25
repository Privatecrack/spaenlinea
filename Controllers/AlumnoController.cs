using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using spaenlinea.Models;
using spaenlinea.Services.Interface;

namespace spaenlinea.Controllers
{
    public class alumnoController : Controller
    {
        private readonly IAlumnoService _alumnoService;

        public alumnoController(IAlumnoService alumnoService)
        {
            _alumnoService = alumnoService;
        }
        [HttpGet]
        [Route("get")]
        public async Task<IQueryable<Alumno>> Get()
        {
            return await _alumnoService.FindAll();
        }
        [HttpGet]
        [Route("get/{idAlumno}")]
        public async Task<Alumno> GetById(Guid idAlumno)
        {
            var query = await _alumnoService.FindByCondition(x => x.id == idAlumno);
            return query.FirstOrDefault();

        }
       
        [HttpPost]
        [Route("save")]
        public async Task<ActionResult> Add([FromBody]Alumno alumno)
        {
            _alumnoService.create(alumno);
            await _alumnoService.SaveChange();
            return CreatedAtAction(nameof(GetById), new {idAlumno = alumno.id }, alumno);
        }
        [HttpDelete]
        [Route("delete/{idAlumno}")]
        public async Task<Alumno> DeleteByName(Guid idAlumno)
        {
            return await _alumnoService.DeleteById(idAlumno);
        }
        [HttpDelete]
        [Route("update}")]
        public async Task<Alumno> Update([FromBody]Alumno alumno)
        {
            return await _alumnoService.Modify(alumno);
        }
    }
}