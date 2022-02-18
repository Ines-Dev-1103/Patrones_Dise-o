using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal Esta = new Animal() { Nombre="Paloma", Clasificacion="Animales vertebrados", Color="Blanca"};
            Animal EstaClonado = new Animal() as Animal;

            EstaClonado.Nombre = "Pato";
            Console.WriteLine(Esta.Nombre);
        }
    }
}
