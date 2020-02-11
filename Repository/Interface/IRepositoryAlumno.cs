using spa.Models;
using System;
using System.Linq;

namespace spa.Repository.Interface.IRepository
{
    public interface IRepositoryAlumno : IRepositoryBase<Alumno>
    {
        IQueryable<Alumno> GetAll();
        Alumno Save(Alumno model);
        Alumno DeleteByName(string name);
        Alumno Modify(Alumno model);
        Alumno GetbyID(Guid id);
    }
}
