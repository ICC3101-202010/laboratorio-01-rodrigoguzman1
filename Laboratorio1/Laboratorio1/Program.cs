using System;

namespace Laboratorio1
{

    class Persona
    {
        string Nombre;
        string Apellido;

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
            Persona persona = new Persona();
            Console.WriteLine(persona.Lanzar());
        }
    }
}
