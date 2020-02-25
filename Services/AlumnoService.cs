using spaenlinea.Models;
using spaenlinea.Repository;
using spaenlinea.Services.Interface;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace spaenlinea.Services
{
    public class AlumnoService : IAlumnoService
    {
        private readonly AlumnoRepository _alumnoRepository;
        public AlumnoService(AlumnoRepository alumnoRepository)
        {
            _alumnoRepository = alumnoRepository;
        }

        public void create(Alumno entity)
        {
            entity.id = new Guid();
            _alumnoRepository.Create(entity);
        }

        public void Delete(Alumno entity)
        {
            _alumnoRepository.Delete(entity);
        }

        public async Task<Alumno> DeleteById(Guid Id)
        {
            var modelToDelete = await _alumnoRepository.FindByCondition(x => x.id == Id);
            _alumnoRepository.Delete(modelToDelete.FirstOrDefault());
            return modelToDelete.FirstOrDefault();
        }

        public async Task<IQueryable<Alumno>> FindAll()
        {
            return await _alumnoRepository.FindByCondition();
        }

        public async Task<IQueryable<Alumno>> FindByCondition(Expression<Func<Alumno, bool>> expression)
        {
            return await _alumnoRepository.FindByCondition(expression);
        }

        public async Task<Alumno> Modify(Alumno alumno)
        {
            var modelToUpdate = await _alumnoRepository.FindByCondition(x => x.id == alumno.id);
            var model = modelToUpdate.FirstOrDefault();
            model = alumno;
            _alumnoRepository.Update(model);
            return modelToUpdate.FirstOrDefault();
        }

        public async Task SaveChange()
        {
            await _alumnoRepository.saveChange();
        }

        public void Update(Alumno entity)
        {
            _alumnoRepository.Update(entity);
        }
    }
}
