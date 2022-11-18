using System;
using System.Collections.Generic;

namespace PresentacionClinica.Models
{
    public partial class Paciente
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
        public string? Nohistoriaclinica { get; set; }
    }
}
