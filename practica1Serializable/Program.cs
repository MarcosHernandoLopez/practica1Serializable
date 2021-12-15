using Newtonsoft.Json;
using System;
using System.IO;

namespace practica1Serializable
{
    
    class Program
    {
        public static void Serialize(object obj, string path)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamWriter(path))
            {
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, obj);
                }
            }
        }

        public static object Deserialize(string path)
        {
            var serializer = new JsonSerializer();
            using (var sw = new StreamReader(path))
            using (var reader = new JsonTextReader(sw))
            {
                return serializer.Deserialize(reader);
            }
        }
        static void Main(string[] args)
        {
            var coche = new DataStructure.Coche(1000, "ROJO", "0000AAA");

            Console.WriteLine("-------Objeto antes del cambio----------");

            Console.WriteLine(Deserialize("json.json").ToString());

            Serialize(coche, "json.json");

            Console.WriteLine("-------Objeto después del cambio----------");

            Console.WriteLine(Deserialize("json.json").ToString());

            Console.ReadLine();
        }
    }
}
