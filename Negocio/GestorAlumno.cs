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
            return new Repositorio.RPAlumno().Registrar(alumno);
        }

        public Entidades.Alumno Buscar(string rut)
        {
            return new Repositorio.RPAlumno().Buscar(rut);
        }

        public bool Modificar(Entidades.Alumno alumno)
        {

            return false;
        }

        public bool Eliminar(string rut)
        {
            Repositorio.RPAlumno rpAlumno = new Repositorio.RPAlumno();
            return rpAlumno.Eliminar(rut);
        }

        public bool ValidarEdad(int edadAlumno)
        {

            return false;
        }

        public bool ValidarDatosAlumno(Entidades.Alumno alumno)
        {
            
            if(string.IsNullOrEmpty(alumno.rut) || string.IsNullOrEmpty(alumno.nombre) || string.IsNullOrEmpty(alumno.apellidos)
                || (alumno.edad<1) || (alumno.edad > 110) || alumno.sexo!=1 || alumno.sexo != 2)
            { 



            }

            return false;
        }

    }
}
