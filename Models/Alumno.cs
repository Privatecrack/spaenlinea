using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace spaenlinea.Models
{
    public class Alumno
    {
        [Key]
        public Guid id { get; set; }
        public string nombre { get; set; }
        [Required(ErrorMessage = "Nombre es requerrido")]
        [MaxLength(30, ErrorMessage = "El nombre no puede ser mayor a 30 digitos")]
        public string calle_numero { get; set; }
        [Required(ErrorMessage = "calle y numero es requerrido")]
        [MaxLength(30, ErrorMessage = "la calle y número no puede ser mayor a 30 digitos")]
        public string colonia { get; set; }
        [Required(ErrorMessage = "Colonia es requerrido")]
        [MaxLength(30, ErrorMessage = "La colonia no puede ser mayor a 30 digitos")]
        public string ciudad_estado { get; set; }
        [Required(ErrorMessage = "Ciudad y estado es requerrido")]
        [MaxLength(30, ErrorMessage = "la ciudad y estado no puede ser mayor a 30 digitos")]
        public string lada { get; set; }
        [Required(ErrorMessage = "Nombre es requerrido")]
        [MaxLength(30, ErrorMessage = "El nombre no puede ser mayor a 30 digitos")]
        public string telefono { get; set; }
        [Required(ErrorMessage = "Telefono es requerrido")]
        [MaxLength(30, ErrorMessage = "El telefono no puede ser mayor a 30 digitos")]
        public string pais { get; set; }
        [Required(ErrorMessage = "Pais es requerrido")]
        [MaxLength(30, ErrorMessage = "El pais no puede ser mayor a 30 digitos")]
        public string codigo_postal { get; set; }
        [Required(ErrorMessage = "Codigo postal es requerrido")]
        [MaxLength(30, ErrorMessage = "El codigo postal no puede ser mayor a 30 digitos")]
        public string religion { get; set; }
        [Required(ErrorMessage = "Religion es requerrido")]
        [MaxLength(30, ErrorMessage = "la religion nombre no puede ser mayor a 30 digitos")]
        public string correo_institucional { get; set; }
        [Required(ErrorMessage = "Correo institucional es requerrido")]
        [MaxLength(30, ErrorMessage = "el correo institucional no puede ser mayor a 30 digitos")]
        public string sexo { get; set; }
        [Required(ErrorMessage = "Sexo es requerrido")]
        [MaxLength(30, ErrorMessage = "El nombre no puede ser mayor a 30 digitos")]
        public string lugar_nacimiento { get; set; }
        [Required(ErrorMessage = "Lugar de nacimiento es requerrido")]
        [MaxLength(30, ErrorMessage = "El lugar de nacimiento no puede ser mayor a 30 digitos")]
        public string nacionalidad { get; set; }
        [Required(ErrorMessage = "Nacionalidad es requerrido")]
        [MaxLength(30, ErrorMessage = "la nacionalidad no puede ser mayor a 30 digitos")]
        public string fecha_de_nacimiento { get; set; }
        [Required(ErrorMessage = "Fecha de nacimiento es requerrido")]
        [MaxLength(30, ErrorMessage = "La Fecha de nacimiento no puede ser mayor a 30 digitos")]
        public string estado_civil { get; set; }
        [Required(ErrorMessage = "Estado civil es requerrido")]
        [MaxLength(30, ErrorMessage = "El estado civil no puede ser mayor a 30 digitos")]
        public string curp { get; set; }
        [Required(ErrorMessage = "Curp es requerrido")]
        [MaxLength(30, ErrorMessage = "El Curp no puede ser mayor a 30 digitos")]
        public string tipo_sangre { get; set; }
        public string alergias { get; set; }
        public string especificar_enfermedad { get; set; }
        public string estudia_unav { get; set; }
        [Required(ErrorMessage = "UNAV es requerrido")]
        [MaxLength(30, ErrorMessage = "Unav no puede ser mayor a 30 digitos")]
        public string entrevistado { get; set; }
        public string no_entrevistado { get; set; }
        public string n_matricula { get; set; }
        public string status { get; set; }
        public string bautizado { get; set; }
        [Required(ErrorMessage = "Bautizo es requerrido")]
        [MaxLength(30, ErrorMessage = "El Bautizo no puede ser mayor a 30 digitos")]
        public string fecha_de_bautizo { get; set; }
    }
}
