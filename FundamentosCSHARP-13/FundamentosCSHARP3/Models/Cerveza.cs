using FundamentosCSHARP3.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FundamentosCSHARP3.Models
{

    public class Cerveza : Bebida, IBebidaAlcoholica, IEquatable<Cerveza?>
    {

        public int Alcohol { get; set; }
        
        public string Marca { get; set; }

        public int id { get; set; }

        public void MaxRecomendado()
        {
            Console.WriteLine("El maximo permitido son: 4");
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as Cerveza);
        }

        public bool Equals(Cerveza? other)
        {
            return other is not null &&
                   Nombre == other.Nombre &&
                   Cantidad == other.Cantidad &&
                   Alcohol == other.Alcohol &&
                   Marca == other.Marca &&
                   id == other.id;
        }

        public Cerveza(int Cantidad, string Nombre = "Cerveza")
            : base(Nombre, Cantidad)
        {

        }

        public Cerveza(string Nombre, int Cantidad) : base(Nombre, Cantidad)
        {
        }

        public Cerveza()
        {
        }

        public static bool operator ==(Cerveza? left, Cerveza? right)
        {
            return EqualityComparer<Cerveza>.Default.Equals(left, right);
        }

        public static bool operator !=(Cerveza? left, Cerveza? right)
        {
            return !(left == right);
        }
    }

    internal interface IBebidaAlcoholica
    {
        void MaxRecomendado();
    }
}
