﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rent.Clases
{
    class Variables
    {
        //variables de usuario
        public static int ID { get; set; }
        public static string NOMBRE { get; set; }
        public static string USER { get; set; }
        public static string PASS { get; set; }
        public static string PERFIL { get; set; }

        //variables de consultas
        public static string accion { get; set; }
        public static string se_guardo { get; set; }
    }
}