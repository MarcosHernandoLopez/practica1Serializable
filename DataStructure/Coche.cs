using System;
using Newtonsoft;

namespace DataStructure
{
    public class Coche
    {
        public Coche(string modelo, int color, string matricula)
        {
            Modelo = modelo;
            Color = color;
            Matricula = matricula;
        }

        public Coche()
        { }

        public string getCaracteristicas() {
            return $"Modelo: {Modelo}\nColor: {Color}";
        }

        public override string ToString()
        {
            return $"Matrícula: {Matricula}\nModelo: {Modelo}\nColor: {Color} ";
        }

        public string Modelo { get; set; }
        public int Color { get; set; }
        public string Matricula { get; set; }
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
