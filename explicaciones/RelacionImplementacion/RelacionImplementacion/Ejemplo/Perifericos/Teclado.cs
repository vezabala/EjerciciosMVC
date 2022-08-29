using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelacionImplementacion.Ejemplo.Perifericos
{
    internal class Teclado : IPeriferico
    {
        public void Conectar()
        {
            Console.WriteLine("Se conecto un teclado por usb");
        }
    }
}
