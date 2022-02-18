using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singelton2
{
    public class Singleton
    {
        private static Singleton instance = null;
        public string prueba = "";
        protected Singleton() 
        {
            prueba = "Esto tiene que funcionar oc?";
        }
        public static Singleton Instance
        {
            get 
            {
                if (instance == null)
                    instance = new Singleton();
                return instance;
            }
        }
    }
}
