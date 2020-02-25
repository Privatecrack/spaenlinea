using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace spaenlinea.Models.Dtos
{
    public class AlumnoDto
    {
        public Guid id { get; set; }
        public string nombre { get; set; }
        public string calle_numero { get; set; }
        public string colonia { get; set; }
        public string ciudad_estado { get; set; }
        public string lada { get; set; }
        public string telefono { get; set; }
        public string pais { get; set; }
        public string codigo_postal { get; set; }
        public string religion { get; set; }
        public string correo_institucional { get; set; }
        public string sexo { get; set; }
        public string lugar_nacimiento { get; set; }
        public string nacionalidad { get; set; }
        public string fecha_de_nacimiento { get; set; }
        public string estado_civil { get; set; }
        public string curp { get; set; }
        public string tipo_sangre { get; set; }
        public string alergias { get; set; }
        public string especificar_enfermedad { get; set; }
        public string estudia_unav { get; set; }
        public string entrevistado { get; set; }
        public string no_entrevistado { get; set; }
        public string n_matricula { get; set; }
        public string status { get; set; }
        public string bautizado { get; set; }
        public string fecha_de_bautizo { get; set; }

    }
}
