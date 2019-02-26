using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appControlAlumnos.Entidades
{

    public class AlumnoBE
    {
        public int IdAlumno { get; set; }
        [Required(ErrorMessage = "Debe ingresar un nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "Debe ingresar un apellido")]
        [StringLength(100)]
        public string Apellido { get; set; }
        public List<CursoBE> oCursoBE { get; set; }

        public List<AdjuntoBE> oAdjuntos { get; set; }
    }
}
