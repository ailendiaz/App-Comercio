﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Marca
    {
        public int ID { get; set; }
        public string descripcion { get; set; }

        public Marca() { }
        public Marca(int ID,string descripcion)
        {
            this.ID = ID;
            this.descripcion = descripcion;
        }
    }
}
