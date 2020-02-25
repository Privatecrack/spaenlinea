using spa.Repository;
using spa.Repository.Data;
using spa.Repository.Interface;
using spaenlinea.Repository;
using spaenlinea.Repository.Interface;

namespace Repository.Repositories.Utils
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private IRepositoryWrapper _repositoryWrapper;
        private RepositoryContext _repositoryContext;

        

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
