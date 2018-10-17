using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public class GestorAlumno
    {

        public bool Registrar(Entidades.Alumno alumno) {
            
            return false;
        }

        public Entidades.Alumno Buscar(string rut)
        {

            return new Entidades.Alumno();
        }

        public bool Modificar(Entidades.Alumno alumno)
        {

            return false;
        }

        public bool Eliminar(string rut)
        {

            return false;
        }

        public bool ValidarEdad(int edadAlumno)
        {

            return false;
        }

    }
}
