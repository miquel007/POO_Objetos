using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp46
{
    class persona
    {
        public class Persona
        {
            string nombre;

            public Persona(string nom)
            {
                nombre = nom;
            }

            public void Saludar()
            {
                Console.WriteLine("Hola, soy {0}", nombre);
            }

            public void SetNombre (string e)
            {
                this.nombre = e;
            }            
        }
    }
}
