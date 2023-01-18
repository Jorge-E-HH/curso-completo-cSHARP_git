using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP3.Models;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;

namespace FundamentosCSHARP3
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            List<Bar> bares = new List<Bar>()
            {
                new Bar("El bar")
                {
                    cervezas = new List<Cerveza>()
                    {
                        new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale", Marca="Minerva"},
                        new Cerveza(){ Alcohol=8, Cantidad=5, Nombre="Ticus", Marca="Colima"},
                        new Cerveza(){ Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"}
                    }
                },
                new Bar("El bar 2")
                {
                    cervezas = new List<Cerveza>()
                    {
                        new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale", Marca="Minerva"},
                        new Cerveza(){ Alcohol=8, Cantidad=5, Nombre="Ticus", Marca="Colima"},
                        
                    }
                },
                new Bar("El bar new")

            };

            var bar = from d in bares
                      where d.cervezas.Where(c => c.Nombre == "Stout").Count()>0
                      select new BarData(d.Nombre)
                      {
                          bebidas = (from c in d.cervezas
                                     select new Bebida(c.Nombre, c.Cantidad)
                                     ).ToList()
                      }
                      ).ToList();

          


        }


    }
}