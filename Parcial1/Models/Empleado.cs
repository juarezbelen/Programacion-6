using System;
using System.Collections.Generic;

namespace Parcial1.Models
{
    public partial class Empleado
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public DateTime? FechaIngreso { get; set; }
        public string? Clave { get; set; }
        public string? Mail { get; set; }
    }
}
