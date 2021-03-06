﻿using GestionAlumnos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestionAlumnos.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        
        //GET
        public ActionResult Registrar()
        {
            ViewBag.Mensaje = "";
            return View(new AlumnoModel());
        }

        //POST
        [HttpPost]
        public ActionResult Registrar(AlumnoModel model)
        {
            AlumnoModel alumnoModel = new AlumnoModel();
            alumnoModel = model;

            Entidades.Alumno alumno = new Entidades.Alumno
            {
                rut = alumnoModel.rut,
                nombre = alumnoModel.nombre,
                apellidos = alumnoModel.apellidos,
                edad = alumnoModel.edad,
                sexo = alumnoModel.sexo
            };

            Negocio.GestorAlumno gestorAlumno = new Negocio.GestorAlumno();
            bool result = gestorAlumno.Registrar(alumno);

            ViewBag.Mensaje = result ? "Alumno Registrado" : "Error al Registrar Alumno";

            return View(alumnoModel);
        }

        //GET
        public ActionResult Buscar()
        {
            return View(new Models.AlumnoModel());
        }

        [HttpPost]
        public ActionResult Buscar(Models.AlumnoModel model)
        {
            Negocio.GestorAlumno gestorAlumno = new Negocio.GestorAlumno();

            Entidades.Alumno alumno = gestorAlumno.Buscar(model.rut);

            if (alumno != null)
            {
                return RedirectToAction("Detalle", alumno);
            }

            return View(new Models.AlumnoModel());
        }

        public ActionResult Detalle(Models.AlumnoModel model)
        {
            return View(model);
        }

        public ActionResult Modificar(string rut)
        {
            Negocio.GestorAlumno gestorAlumno = new Negocio.GestorAlumno();

            Entidades.Alumno alumno = gestorAlumno.Buscar(rut);
            Models.AlumnoModel alumnoModel = new AlumnoModel
            {
                rut = alumno.rut,
                nombre = alumno.nombre,
                apellidos = alumno.apellidos,
                edad = alumno.edad,
                sexo = alumno.sexo
            };

            if (alumno != null)
            {
                return View(alumnoModel);
            }

            return RedirectToAction("Buscar", new AlumnoModel());
        }

        [HttpPost]
        public ActionResult Modificar(Models.AlumnoModel model)
        {
            AlumnoModel alumnoModel = new AlumnoModel();
            alumnoModel = model;

            Entidades.Alumno alumno = new Entidades.Alumno()
            {
                rut = alumnoModel.rut,
                nombre = alumnoModel.nombre,
                apellidos = alumnoModel.apellidos,
                edad = alumnoModel.edad,
                sexo = alumnoModel.sexo
            };

            Negocio.GestorAlumno gestorAlumno = new Negocio.GestorAlumno();
            alumno = gestorAlumno.Modificar(alumno);

            if (alumno != null)
            {
                return RedirectToAction("Detalle", alumno);
            }

            return View();
        }

        [HttpGet]
        public ActionResult Eliminar(string rut)
        {
            Negocio.GestorAlumno gestorAlumno = new Negocio.GestorAlumno();

            Entidades.Alumno alumno = gestorAlumno.Buscar(rut);
            Models.AlumnoModel alumnoModel = new AlumnoModel
            {
                rut = alumno.rut,
                nombre = alumno.nombre,
                apellidos = alumno.apellidos,
                edad = alumno.edad,
                sexo = alumno.sexo
            };

            if (alumno.rut != null)
            {
                return View(alumnoModel);
            }

            return RedirectToAction("Buscar", new AlumnoModel());
        }

        [HttpPost]
        public ActionResult Eliminar(AlumnoModel model)
        {
            Negocio.GestorAlumno gestorAlumno = new Negocio.GestorAlumno();
            bool result = gestorAlumno.Eliminar(model.rut);

            if (result)
            {
                return RedirectToAction("Index","Home");
            }

            return View();
        }

    }
}