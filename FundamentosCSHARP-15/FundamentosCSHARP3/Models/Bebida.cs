using System.Collections.Generic;
using System.Text;
using System;

namespace FundamentosCSHARP3.Models
{

    public class Bebida
    {
        public string Nombre { get; set; }

        public int Cantidad { get; set; }

        public Bebida(string Nombre, int Cantidad)
        {
            this.Nombre = Nombre;
            this.Cantidad = Cantidad;
        }

        public void Beberse(int CuantoBebio)
        {
            this.Cantidad -= CuantoBebio;
        }
    }

}

