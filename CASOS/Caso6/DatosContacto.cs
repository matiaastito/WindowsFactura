﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CASOS.Caso6
{
    public class DatosContacto
    {
        public string Domicilio { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public Cliente Cliente { get; set; }
        public Empleado Empleado { get; set; }
    }
}
