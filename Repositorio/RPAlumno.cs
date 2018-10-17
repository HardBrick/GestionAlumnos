using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositorio
{
    class RPAlumno
    {
        public bool Crear(Entidades.Alumno alumno)
        {
            DataAlumno.rut = alumno.rut;
            DataAlumno.nombre = alumno.nombre;
            DataAlumno.apellidos = alumno.apellidos;
            DataAlumno.edad = alumno.edad;
            DataAlumno.sexo = alumno.sexo;

            return true;
        }

        public Entidades.Alumno Buscar(string rut)
        {
            Entidades.Alumno alumno = new Entidades.Alumno();
            if (rut == DataAlumno.rut)
            {
                alumno = new Entidades.Alumno
                {
                    rut = DataAlumno.rut,
                    nombre = DataAlumno.nombre,
                    apellidos = DataAlumno.apellidos,
                    edad = DataAlumno.edad,
                    sexo = DataAlumno.sexo
                };

                return alumno;
            }

            return null;
        }

        public Entidades.Alumno Actualizar(Entidades.Alumno alumno)
        {
            if (alumno.rut == DataAlumno.rut)
            {
                DataAlumno.rut = alumno.rut;
                DataAlumno.nombre = alumno.nombre;
                DataAlumno.apellidos = alumno.apellidos;
                DataAlumno.edad = alumno.edad;
                DataAlumno.sexo = alumno.sexo;
                

                alumno = new Entidades.Alumno
                {
                    rut = DataAlumno.rut,
                    nombre = DataAlumno.nombre,
                    apellidos = DataAlumno.apellidos,
                    sexo = DataAlumno.sexo,
                    edad = DataAlumno.edad
                };

                return alumno;
            }

            return null; // Retorna NULL cuando no fue posible actualizar el producto
        }

        public bool Eliminar(string rut)
        {
            if (rut == DataAlumno.rut)
            {
                DataAlumno.rut = null;
                DataAlumno.nombre = null;
                DataAlumno.apellidos = null;
                DataAlumno.edad = 0;
                DataAlumno.sexo = 0;

                return true;
            }

            return false;
        }
    }
}
