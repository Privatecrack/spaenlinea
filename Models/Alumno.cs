using System;
using System.ComponentModel.DataAnnotations;


namespace spa.Models
{
    public class Alumno
    {
        public Guid AlumnoId { get; set; }
        [Required(ErrorMessage = "Nombre es requerid")]
        [StringLength(60, ErrorMessage = "El nombre no puede tener mas de 60 caracteres")]
        public string Name { get; set; }
    }
}
