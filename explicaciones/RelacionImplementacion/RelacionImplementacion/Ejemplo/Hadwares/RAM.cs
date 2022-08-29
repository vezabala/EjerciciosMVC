using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionImplementacion.Ejemplo.Hadwares
{
    internal class RAM : Hadware
    {
        public override void ConeccionElectrica()
        {
            Console.WriteLine("Conecta a 5V");
        }
    }
}
