﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS.Caso4
{
    public class Docente
    {
        public string Nombre { get; set; }
        public string Materia { get; set; }
        public string Email { get; set; }
        public List<Alumno> Alumnos { get; set; }
    }
}
