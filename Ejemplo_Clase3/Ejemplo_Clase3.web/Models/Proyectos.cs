namespace Ejemplo_Clase3.web.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Proyectos
    {
        [Key]
        public int ProyectoId { get; set; }

        [StringLength(100)]
        public string Nombre { get; set; }

        public int GerenteId { get; set; }

        public int SupervisorId { get; set; }

        public virtual Personas Personas { get; set; }

        public virtual Personas Personas1 { get; set; }
    }
}
