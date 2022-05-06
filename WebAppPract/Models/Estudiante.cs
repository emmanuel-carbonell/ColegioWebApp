using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAppPract.Models
{
    public class Estudiante
    {
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public int Telefono { get; set; }
        public string Email { get; set; }
        public string Genero { get; set; }

        public string EstadoCivil { get; set; }

        public string Hobby { get; set; }

        public string Foto { get; set; }

    }
}