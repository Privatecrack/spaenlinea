using Microsoft.EntityFrameworkCore;
using spaenlinea.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace spa.Repository.Data
{
    public class RepositoryContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {

        }

        public System.Data.Entity.DbSet<Alumno> Alumno { get; set; }
    }
}
