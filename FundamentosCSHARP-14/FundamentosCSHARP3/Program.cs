using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP3.Models;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using FundamentosCSHARP3.Service;

namespace FundamentosCSHARP3
{
    class Program
    {

        static async Task Main(string[] args)
        {
            Action<string, string> mostrar = Show;
            HacerAlgo(mostrar);
        }

        public static void HacerAlgo(Action<string, string> funcionFinal)
        {
            Console.WriteLine("HAGO ALGO");
            funcionFinal("se envio desde otra funcion", "otra cadena we");
            Console.WriteLine("HAGO ALGO MAS");

        } 

        public static void Show(string cad, string cad2)
        {
            Console.WriteLine(cad+cad2);
        }

        public static int Show(string cad)
        {
            return cad.Count();

        }


    }
}