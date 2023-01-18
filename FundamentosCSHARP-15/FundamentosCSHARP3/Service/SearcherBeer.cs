using FundamentosCSHARP3.Errors;
using FundamentosCSHARP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundamentosCSHARP3.Service
{
    public class SearcherBeer
    {
        List<Cerveza> cervezas = new List<Cerveza>()
        {
            new Cerveza() { Alcohol = 7, Cantidad = 10, Nombre = "Pale", Marca = "Minerva" },
            new Cerveza() { Alcohol = 8, Cantidad = 5, Nombre = "Ticus", Marca = "Colima" },
            new Cerveza() { Alcohol = 7, Cantidad = 8, Nombre = "Stout", Marca = "Minerva" }


        };

        public int GetCantidad(string Nombre)
        {
            var cerveza = (from d in cervezas
                          where d.Nombre == Nombre
                          select d).FirstOrDefault();
            if (cerveza == null)
                throw new BeerNotFountException("La cerveza no compila");

            return cerveza.Cantidad;
        }
    }

}

