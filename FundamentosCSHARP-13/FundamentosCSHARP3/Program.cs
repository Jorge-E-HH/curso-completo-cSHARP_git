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
    public class Program
    {
        static async Task Main(string[] args)
        {

            try
            {
                var searcherBeer = new SearcherBeer();
                var cantidad = searcherBeer.GetCantidad("jsjsjs");
                Console.WriteLine("Todo bien");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Finally siempre se ejecuta al final, siempre que haya un try, debe de llevar" +
                    "un catch o un finally o ambos");
            }


        }


    }
}