using spaenlinea.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace spaenlinea.Services.Interface
{
    public interface IAlumnoService
    {
        void create(Alumno entity);
        void Delete(Alumno entity);
        Task<IQueryable<Alumno>> FindAll();
        Task<IQueryable<Alumno>> FindByCondition(Expression<Func<Alumno, bool>> expression);
        void Update(Alumno entity);
        Task SaveChange();
        Task<Alumno> DeleteById(Guid Id);
        Task<Alumno> Modify(Alumno alumno);


    }
}
