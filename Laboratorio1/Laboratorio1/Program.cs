using System;

namespace Laboratorio1
{

    class Persona
    {
        string Nombre;
        string Apellido;

        public Persona(string nombre, string apellido)
        {
            this.Nombre = nombre;
            this.Apellido = apellido;
        }

        public int Lanzar()
        {
            int randomInt = new Random().Next(0, 3);
            return randomInt;
        }
        
    }

    class MainClass
    {
        public static void Main(string[] args)
        {
            Persona persona = new Persona("Bob", "Kunga");
            Console.WriteLine(persona.Lanzar());
        }
    }
}
