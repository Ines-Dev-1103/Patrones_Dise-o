using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Singleton.Instance.prueba);
            Singleton.Instance.prueba = "Efectivamente funciona mi estimada";
            Console.WriteLine(Singleton.Instance.prueba);
        }
    }
}
