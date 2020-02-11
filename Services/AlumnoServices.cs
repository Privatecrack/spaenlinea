using spa.Models;
using spa.Repository.Interface.IRepository;
using spa.Services.Interface;
using System;
using System.Linq;

namespace spa.Services
{
    public class AlumnoServices : IServicesAlumno
    {
        private readonly IRepositoryAlumno _repositoryAlumno;
        public AlumnoServices(IRepositoryAlumno repositoryAlumno)
        {
            _repositoryAlumno = repositoryAlumno;
        }

        public Alumno DeleteByName(string name)
        {
            return _repositoryAlumno.DeleteByName(name);
        }

        public IQueryable<Alumno> GetAll()
        {
            return _repositoryAlumno.FindAll();
        }

        public Alumno GetById(Guid Id)
        {
            return _repositoryAlumno.GetbyID(Id);
        }

        public Alumno Save(Alumno Alumno)
        {
            return _repositoryAlumno.Save(Alumno);
        }

        public Alumno Update(Alumno model)
        {
            return _repositoryAlumno.Modify(model);
        }
    }
}
