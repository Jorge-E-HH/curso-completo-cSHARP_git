using System;
using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using FundamentosCSHARP.Models;
using FundamentosCSHARP3.Models;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.IO;
using System.Threading.Tasks;
using System.Net.Http;


namespace FundamentosCSHARP3
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var cerveza = new Cerveza()
            { Alcohol = 5, Cantidad = 500, Marca = "Colima", Nombre = "Ticús" };

            Service.SendRequest<Cerveza> service = new Service.SendRequest<Cerveza>();
            var CervezaResspuesta = await service.Send(cerveza);
        }


    }
}