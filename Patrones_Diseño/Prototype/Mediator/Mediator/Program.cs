using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediator
{
    class Program
    {
        static void Main(string[] args)
        {
           Mediator mediator = new Mediator();
           
           IColleague oPepe = new User(mediator);
           IColleague oAdmin = new User(mediator);

            mediator.Add(oPepe);
            mediator.Add(oAdmin);

            oPepe.Communicate("Klk admin");
        }
    }
}
