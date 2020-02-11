using System.Linq;
using System;
using spa.Models;
using spa.Repository.Interface.IRepository;
using spa.Repository.Interface;
using spa.Repository.Data;
using Repository.Repositories.Utils;

namespace Repository.Repositories
{
    public class AlumnoRepository : RepositoryBase<Alumno>, IRepositoryAlumno
    {
        private IRepositoryWrapper _repositoryWrapper;


        public AlumnoRepository
           (
            RepositoryContext repositoryContext,
            IRepositoryWrapper repositoryWrapper
           )
             : base(repositoryContext)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public IQueryable<Alumno> GetAll()
        {
            return _repositoryWrapper.Alumno.FindAll();
        }

        public Alumno Save(Alumno model)
        {
            _repositoryWrapper.Alumno.Create(model);
            _repositoryWrapper.save();

            return model;
        }

        public Alumno Modify(Alumno model)
        {

            var entity = _repositoryWrapper.Alumno.FindByCondition(item => item.AlumnoId == model.AlumnoId).FirstOrDefault();
            entity.Name = model.Name;

            _repositoryWrapper.Alumno.Update(entity);
            _repositoryWrapper.save();

            return model;
        }

        public Alumno DeleteByName(string name)
        {
            var modelToEliminate = _repositoryWrapper.Alumno
                                    .FindByCondition(x => x.Name == name)
                                    .Where(x => x.Name == name)
                                    .FirstOrDefault();

            _repositoryWrapper.Alumno.Delete(modelToEliminate);
            _repositoryWrapper.save();

            return modelToEliminate;
        }

        public Alumno GetbyID(Guid id)
        {
            return _repositoryWrapper.Alumno.FindByCondition(item => item.AlumnoId == id).FirstOrDefault();
        }
    }
}