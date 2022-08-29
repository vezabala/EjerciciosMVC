using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionImplementacion.Ejemplo.Hadwares
{
    internal class Procesador : Hadware
    {
        public override void ConeccionElectrica()
        {
            Console.WriteLine("Conecta a 4V");
        }
    }
}
