using System.Linq;
using System;
using spa.Models;

namespace spa.Services.Interface
{
    public interface IServicesAlumno
    {
        IQueryable<Alumno> GetAll();
        Alumno Save(Alumno Alumno);
        Alumno DeleteByName(String name);
        Alumno Update(Alumno model);
        Alumno GetById(Guid Id);

    }
}
