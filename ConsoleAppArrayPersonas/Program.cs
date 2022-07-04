using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace ConsoleAppArrayPersonas
{
    class Program
    {
        static void Main(string[] args)
        {
            var personas = new Persona[]
            {
                new Persona() {Nombre = "David"},
                new Persona {Nombre = "John"},
                new Persona() {Nombre = "Mary"},
                new Persona() {Nombre = "Brandy"}
            };
            MostrarContenido(personas);
            Console.WriteLine($"Cantidad de personas: {personas.Length}");
            Persona personaBuscada = new Persona() {Nombre = "David"};

            bool existe = personas.Contains(personaBuscada);
            Console.WriteLine(existe);

            Console.ReadLine();
        }

        private static void MostrarContenido(Persona[] personas)
        {
            foreach (var persona in personas)
            {
                Console.WriteLine($"{persona}");
            }
        }
    }
}
