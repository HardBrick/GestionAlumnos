using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GestionAlumnos.Models
{
    public class AlumnoModel
    {
        public string rut { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public int edad { get; set; }
        public int sexo { get; set; }
    }
}