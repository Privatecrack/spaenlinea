using spa.Repository;
using spa.Repository.Data;
using spa.Repository.Interface;
using spa.Repository.Interface.IRepository;

namespace Repository.Repositories.Utils
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IRepositoryAlumno _repositoryAlumno;
        private IRepositoryWrapper _repositoryWrapper;
        private RepositoryContext _repositoryContext;

        public IRepositoryAlumno Alumno
        {
            get
            {
                if (_repositoryAlumno == null)
                {
                    _repositoryAlumno = new AlumnoRepository(_repositoryContext, _repositoryWrapper);
                }

                return _repositoryAlumno;
            }
        }

        public IRepositoryAlumno Alumnos => _repositoryWrapper.Alumno;

        public RepositoryWrapper(RepositoryContext repositoryContext)
        {
            _repositoryContext = repositoryContext;
        }

        public void save()
        {
            _repositoryContext.SaveChanges();
        }
    }
}
