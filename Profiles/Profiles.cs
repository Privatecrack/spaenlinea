using AutoMapper;
using spaenlinea.Models;
using spaenlinea.Models.Dtos;


namespace spaenlinea.Profiles
{
    public class Profiles : Profile
    {
        public Profiles()
        {
            CreateMap<Alumno, AlumnoDto>();
        }
    }
}
