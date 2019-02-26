using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appControlAlumnos.Entidades
{
 
    public class CursoBE
    {
        public int IdCurso { get; set; }
        [Required]
        [StringLength(100)]
        public string Nombre { get; set; }

    }
}
