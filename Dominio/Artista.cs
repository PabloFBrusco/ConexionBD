﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Artista
    {
        public string Nombre { get; set; }
        public int Id { get; set; }

        public override string ToString()
        {
            return Nombre;
        }
    }
}
