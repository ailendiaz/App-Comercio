﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Categoria
    {
        public int ID { get; set; }
        public string descripcion { get; set; }

        public Categoria( string descripcion)
        {
            this.descripcion = descripcion;
        }
        public Categoria() { }

    }
}
