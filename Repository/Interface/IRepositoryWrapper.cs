using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using spa.Repository.Interface;
using spa.Repository.Interface.IRepository;

namespace spa.Repository.Interface
{
    public interface IRepositoryWrapper
    {
        IRepositoryAlumno Alumno { get; }

        void save();
    }
}
