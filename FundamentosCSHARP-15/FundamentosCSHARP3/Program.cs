using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP3.Models;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;
using System.Linq;
using FundamentosCSHARP3.Service;
using FundamentosCSHARP3.Errors;
using System.Security.Cryptography.X509Certificates;

namespace FundamentosCSHARP3
{
    static class Program
    {

        public class Beer
        {

            public int Alcohol { get; set; }

            public string Name { get; set; }
        }

        static void Main(string[] args)
        {
            var beers = new List<Beer>() {
             new Beer() { Name = "Ipa", Alcohol = 7 },
             new Beer() { Name = "Pale", Alcohol = 8 },
             new Beer() { Name = "Stout", Alcohol = 9 },
             new Beer() { Name = "Tripel", Alcohol = 15 }

            };

            beers.ShowBeerThatIGetDrunk( x => x.Alcohol >= 8);

        }   
        
        static void ShowBeerThatIGetDrunk(this List<Beer> beers, Predicate<Beer> condition)
        {
            var evilBeers = beers.FindAll(condition);
            evilBeers.ForEach(d => Console.WriteLine(d.Name));
        }

    }
}