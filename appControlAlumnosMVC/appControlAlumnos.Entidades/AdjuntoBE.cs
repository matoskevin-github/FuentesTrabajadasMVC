using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appControlAlumnos.Entidades
{

    public partial class AdjuntoBE
    {
        public int IdAdjunto { get; set; }
        public int IdAlumno { get; set; }
        [Required]
        [StringLength(200)]
        public string Archivo { get; set; }      
        List<AlumnoBE> oAlumnoBE { get; set; }
    }
}
