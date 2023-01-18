using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP3.Models
{
    public class BarData
    {
        public string Nombre { get; set; }
        public List<Bebida> bebidas = new List<Bebida>();

        public BarData(string Nombre)
        {
            this.Nombre = Nombre;
        }

    }
}
