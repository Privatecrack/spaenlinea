using Repository.Repositories.Utils;
using spa.Repository.Data;
using spaenlinea.Models;
using spaenlinea.Repository.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spaenlinea.Repository
{
    public class AlumnoRepository : RepositoryBase<Alumno>, IRepositoryAlumno
    {
        public AlumnoRepository(RepositoryContext repositoryContext) : base(repositoryContext)
        {

        }

        internal Task<IQueryable<Alumno>> FindByCondition()
        {
            throw new NotImplementedException();
        }
    }
}
