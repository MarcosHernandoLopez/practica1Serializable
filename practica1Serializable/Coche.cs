using System;
using Newtonsoft;

namespace DataStructure
{
    public class Coche
    {
        public Coche(int precio, String color, string matricula)
        {
            Precio = precio;
            Color = color;
            Matricula = matricula;
        }

        public Coche()
        { }

        public string getCaracteristicas() {
            return $"Precio: {Precio}\nColor: {Color}";
        }

        public override string ToString()
        {
            return $"Matrícula: {Matricula}\nPrecio: {Precio}\nColor: {Color} ";
        }

        public int Precio { get; set; }
        public String Color { get; set; }
        public string Matricula { get; set; }

    }
}
