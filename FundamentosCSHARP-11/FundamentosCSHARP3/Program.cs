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
    class Program
    {
        static async Task Main(string[] args)
        {
            List<Cerveza> cervezas = new List<Cerveza>()
            {
                new Cerveza(){ Alcohol=7, Cantidad=10, Nombre="Pale", Marca="Minerva"},
                new Cerveza(){ Alcohol=8, Cantidad=5, Nombre="Ticus", Marca="Colima"},
                new Cerveza(){ Alcohol=7, Cantidad=8, Nombre="Stout", Marca="Minerva"},
                new Cerveza(){ Alcohol=6, Cantidad=100, Nombre="Piedra L", Marca="Colima"},

            };
            var cervezasOrdenadas = from d in cervezas
                                    orderby d.Marca
                                    select d;

            foreach (var cerveza in cervezasOrdenadas){
                Console.WriteLine($"{cerveza.Nombre} {cerveza.Marca}");
            }


        }


    }
}